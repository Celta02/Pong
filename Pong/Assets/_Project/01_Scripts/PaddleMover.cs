using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    [RequireComponent(typeof(Rigidbody))]
    public class PaddleMover : MonoBehaviour
    {
        [SerializeField] Paddle _side;
        [SerializeField] float _velocity;

        Rigidbody _rigidbody;
        PlayerInput _controls;
        float _movementInput;

        void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _controls = new PlayerInput();
        }

        void OnEnable() => _controls.Enable();
        void OnDisable() => _controls.Disable();

        void Update()
        {
            if (_controls == null) return;
            _movementInput = ReadValue();
        }

        float ReadValue() => _side == Paddle.Left 
                ? _controls.WASD.PaddleMove.ReadValue<float>() 
                : _controls.Arrows.PaddleMove.ReadValue<float>();

        void FixedUpdate() => Move(_movementInput);

        void Move(float readValue) => _rigidbody.velocity = new Vector3(0f, 0f, readValue) * _velocity * Time.deltaTime;
    }
}
