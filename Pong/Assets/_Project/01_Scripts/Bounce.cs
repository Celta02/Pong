using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class Bounce : MonoBehaviour
    {
        [Tooltip("This factor multiplies the X direction after Bounce. Allowing to have less occurrences of the ball hitting form barrier to barrier.")]
        [SerializeField] float _xBounceFactor = 1.15f;
        Rigidbody _rigidbody;
        BallSpeed _speed;

        void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _speed = GetComponent<BallSpeed>();
        }

        void OnCollisionEnter(Collision collision)
        {
            var normal = collision.contacts[0].normal;
            var newDir = Vector3.Reflect(_rigidbody.velocity, normal).normalized;
            newDir += new Vector3(newDir.x * _xBounceFactor, 0f, 0f);
            _rigidbody.velocity = newDir.normalized * _speed.CurrentSpeed;
            
        }

    }
}
