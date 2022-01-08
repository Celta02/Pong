using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace CeltaGames._Project._01_Scripts
{
    [RequireComponent(typeof(AudioSource))]
    public class BallSfx : MonoBehaviour
    {
        [SerializeField] AudioClip _paddleBounce;
        [SerializeField] AudioClip _wallBounce;
        [SerializeField] AudioClip _goal;
        
        AudioSource _audio;

        float _coolDown = 1f;
        float _elapsedTime;

        void Awake() => _audio = GetComponent<AudioSource>();

        void Update()
        {
            _elapsedTime += Time.deltaTime;
        }

        void PlaySound(AudioClip clip)
        {
            if (!clip) return;
             _audio.PlayOneShot(clip);
        }

        public void PlayWallBounce()
        {
            if (_elapsedTime < _coolDown) return;
            _elapsedTime = 0f;
            PlaySound(_wallBounce);
        }

        public void PlayPaddleBounce() => PlaySound(_paddleBounce);
        public void PlayGoal() => PlaySound(_goal);
    }
}