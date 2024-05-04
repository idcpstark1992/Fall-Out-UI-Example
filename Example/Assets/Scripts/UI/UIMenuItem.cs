using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Demo.Commons;
using UnityEngine.EventSystems;
namespace Demo.UI
{
    public class UIMenuItem : MonoBehaviour
    {
        [SerializeField] private UIMenuItemPopUp _popUp;
        [SerializeField] private UIAudioTrigger  _audio;
        [SerializeField] private Image           _image;
        [SerializeField] private TextMeshProUGUI _text;
        private int     _localIndex;
        EventTrigger    _localEventTrigger;
        private void Awake()
        {
            _audio = gameObject.AddComponent<UIAudioTrigger>();
            _localEventTrigger = GetComponent<EventTrigger>();
            CreateEventsEntrys();
        }
        private void CreateEventsEntrys()
        {
            EventTrigger.Entry m_entry = new()
            {
                eventID = EventTriggerType.PointerClick
            };
            m_entry.callback.AddListener(OnPointer);
            _localEventTrigger.triggers.Add(m_entry);
        }
        private void OnPointer(BaseEventData arg0)
        {
            Subscriptions.ON_ITEM_SELECTED?.Invoke(false);
            Subscriptions.ON_ITEM_CLICKED?.Invoke(_localIndex);
            OnSelected(true);
        }
        private void OnEnable()
        {
            Subscriptions.ON_ITEM_SELECTED += OnSelected;
        }
        private void OnDisable()
        {
            Subscriptions.ON_ITEM_SELECTED -= OnSelected;
        }
        public void OnSelected(bool _bool)
        {
            _image.color = _bool ? UIParameters.SelectedColor : UIParameters.IdleColor;
            _text.color = _bool ? UIParameters.SelectedFontColor : UIParameters.IdleFontColor;
            _popUp.Fold(_bool);
            _audio.TriggerSound();
        }
        public void InitIndex(int _index)
        {
            _localIndex = _index;
            _audio.TriggerSound();
        }
    }
}
