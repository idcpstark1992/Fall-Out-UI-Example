using Demo.Commons;
using UnityEngine;

namespace Demo.UI
{
    public class UIMenuItemPopUp : MonoBehaviour
    {

        private void Start()
        {
            gameObject.transform.localScale = Vector3.zero;
        }

        public void Fold(bool _bool)
        {
            Vector3 targetScale = _bool ? Vector3.one : Vector3.zero;
            if (gameObject.transform.localScale != targetScale)
            {
                LeanTween.scale(gameObject, targetScale, UIParameters.ScaleMotionSpeed).setEaseInOutExpo();
            }
        }
    }
}
