using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class BallSpeed : MonoBehaviour
    {
        [SerializeField] float _initialSpeed = 6f;
        [SerializeField] float _finalSpeed = 28f;
        float _currentSpeed = 3f;

        public float InitialSpeed => _initialSpeed;
        public float CurrentSpeed => _currentSpeed;
        void Awake() => _currentSpeed = _initialSpeed;

        public void AugmentSpeed(float increaseFactor = 1.2f) => _currentSpeed = _currentSpeed < _finalSpeed
            ? _currentSpeed * increaseFactor
            : _finalSpeed;

        public void ResetCurrentSpeed() => _currentSpeed = _initialSpeed;
    }
}
