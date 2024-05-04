using UnityEngine;
namespace Demo.Audio
{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance {  get; private set; }
        [SerializeField] private AudioSource    _musicSource;
        [SerializeField] private AudioSource    _sfxSource;
        [SerializeField] private AudioClip      _musicClip;
        [SerializeField] private AudioClip      _sfxClip;

        private void Awake()
        {
            Instance = this;
            _sfxSource.clip = _sfxClip;
        }
        public void PlayButtonSound()
        {
            _sfxSource.Play();
        }
    }
}
