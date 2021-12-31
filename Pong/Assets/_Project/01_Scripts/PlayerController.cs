using System;
using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public abstract class PlayerController : MonoBehaviour
    {
        public event Action<Paddle> ControllerShoot = delegate { };

        PaddleMover _mover;
        protected PlayerInput Controls;

        protected void Awake()
        {
            Controls = new PlayerInput();
            _mover = GetComponent<PaddleMover>();
        }
        void OnEnable() => Controls.Enable();
        void OnDisable() => Controls.Disable();

        void Start() => SubscribeShoot();
        protected abstract void SubscribeShoot();

        protected void Update()
        {
            if (Controls == null) return;
            _mover.MovementInput = ReadValue();
        }
        protected abstract float ReadValue();

        protected void Shoot(Paddle side) => ControllerShoot.Invoke(side);
    }
}
