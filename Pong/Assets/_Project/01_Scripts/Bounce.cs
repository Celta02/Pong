using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class Bounce : MonoBehaviour
    {
        [Tooltip("This factor multiplies the X direction after Bounce. Allowing to have less occurrences of the ball hitting form barrier to barrier.")]
        [SerializeField] float _xBounceFactor = 1.15f;
        [SerializeField] GameManager _gameManager;
        
        Rigidbody _rigidbody;
        BallSpeed _speed;
        BallSfx _audio;

        void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _speed = GetComponent<BallSpeed>();
            _audio = GetComponent<BallSfx>();
        }

        void OnCollisionEnter(Collision collision)
        {
            var isPaddle = collision.gameObject.CompareTag("Paddle");

            var normal = collision.contacts[0].normal;
            var newDir = Vector3.Reflect(_rigidbody.velocity, normal).normalized;
            
            if (isPaddle)
            {
                _audio.PlayPaddleBounce();
                _gameManager.Touch();
            }
            else
            {
                _audio.PlayWallBounce();
                newDir += new Vector3(newDir.x * _xBounceFactor, 0f, 0f);
            }
            
            _rigidbody.velocity = newDir.normalized * _speed.CurrentSpeed;
        }
    }
}
