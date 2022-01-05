using System;

namespace CeltaGames._Project._01_Scripts
{
    public abstract class PlayerController : GameController
    {
        public event Action<Paddle> ControllerShoot = delegate { };

        protected PlayerInput Controls;

        protected override void Awake()
        {
            base.Awake();
            Controls = new PlayerInput();
        }

        void OnEnable() => Controls.Enable();
        void OnDisable() => Controls.Disable();

        void Start() => SubscribeShoot();
        protected abstract void SubscribeShoot();

        protected void Update()
        {
            if (Controls == null) return;
            MovePaddle(ReadValue());
        }
        protected abstract float ReadValue();

        protected void Shoot(Paddle side) => ControllerShoot.Invoke(side);
    }
}
