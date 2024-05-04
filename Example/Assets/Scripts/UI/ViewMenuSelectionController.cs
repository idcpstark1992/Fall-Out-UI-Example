using Demo.Commons;
using System.Collections.Generic;
using UnityEngine;

namespace Demo.UI
{
    public class ViewMenuSelectionController : MonoBehaviour
    {

        [SerializeField] private List<UIMenuItem> _menuItemslist;
        private int _selectedIndex = -1;
        private void OnEnable()
        {
            Subscriptions.ON_ITEM_CLICKED += OnClickedItemCalled;
        }
        private void OnDisable()
        {
            Subscriptions.ON_ITEM_CLICKED -= OnClickedItemCalled;
        }
        private void OnClickedItemCalled(int _index)
        {
            _selectedIndex = _index;
        }
        private void Start()
        {
            Subscriptions.ON_ITEM_SELECTED?.Invoke(false);
            SetItemsIndex();
        }
        private void SetItemsIndex()
        {
            for (int i = 0; i < _menuItemslist.Count; i++)
            {
                _menuItemslist[i].InitIndex(i);
            }
        }

        //  used with Fixed keys.
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                SelectedDirection(false);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                SelectedDirection(true);
            }
        }
        private void SelectedDirection(bool _up)
        {
            _selectedIndex += _up ? -1 : 1;
            _selectedIndex = Mathf.Clamp(_selectedIndex,0, _menuItemslist.Count-1);   
            Subscriptions.ON_ITEM_SELECTED?.Invoke(false);
            _menuItemslist[_selectedIndex].OnSelected(true);
        }
    }

}
