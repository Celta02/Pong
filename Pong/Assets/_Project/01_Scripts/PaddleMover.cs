using System;
using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    [RequireComponent(typeof(Rigidbody))]
    public class PaddleMover : MonoBehaviour
    {
        Rigidbody _rigidbody;
        float _velocity = 500f;
        float _movementInput = 0f;

        public float MovementInput { set => _movementInput = value; }

        void Awake() => _rigidbody = GetComponent<Rigidbody>();
        void FixedUpdate() => Move(_movementInput);
        void Move(float readValue) => _rigidbody.velocity = new Vector3(0f, 0f, readValue) * _velocity * Time.deltaTime;
    }
}
