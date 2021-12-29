using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

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
            _controls = new PlayerInput();
            _rigidbody = GetComponent<Rigidbody>();

        }

        void OnEnable() => _controls.Enable();
        void OnDisable() => _controls.Disable();
/*
        void Start()
        {
            if (_side == Paddle.Left) 
                _controls.WASD.PaddleMove.performed += input => Move(input.ReadValue<float>());
            else
                _controls.Arrows.PaddleMove.performed += input => Move(input.ReadValue<float>());
        }

        void OnDestroy()
        {
            if (_controls == null) return;
            if (_side == Paddle.Left) 
                _controls.WASD.PaddleMove.performed -= input => Move(input.ReadValue<float>());
            else
                _controls.Arrows.PaddleMove.performed -= input => Move(input.ReadValue<float>());
        }*/

        void Update()
        {
            if (_controls == null) return;
            _movementInput = _side == Paddle.Left 
                ? _controls.WASD.PaddleMove.ReadValue<float>() 
                : _controls.Arrows.PaddleMove.ReadValue<float>();
        }
        void FixedUpdate() => Move(_movementInput);

        void Move(float readValue)
        {
            Debug.Log($"Value: {readValue}");
            _rigidbody.velocity = new Vector3(0f, 0f, readValue) * _velocity * Time.deltaTime;
        }
        
        
    }
}
