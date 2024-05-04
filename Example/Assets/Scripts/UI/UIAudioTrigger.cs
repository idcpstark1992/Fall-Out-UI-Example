using Demo.Audio;
using UnityEngine;

namespace Demo.UI
{
    public class UIAudioTrigger : MonoBehaviour
    {
        public void TriggerSound()
        {
            AudioManager.Instance.PlayButtonSound();
        }
    }
}
