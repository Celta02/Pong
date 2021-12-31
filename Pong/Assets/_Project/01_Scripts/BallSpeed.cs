using System;
using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class BallSpeed : MonoBehaviour
    {
        [SerializeField] float _initialSpeed = 6f;
        float _currentSpeed = 3f;
        float _targetSpeed = 2f;

        public float InitialSpeed => _initialSpeed;
        public float CurrentSpeed => _currentSpeed;
        void Awake() => _currentSpeed = _targetSpeed = _initialSpeed;

        public void AugmentSpeed(float increaseFactor = 1.2f) => _currentSpeed *= increaseFactor;
        public void ResetCurrentSpeed() => _currentSpeed = _initialSpeed;
    }
}
