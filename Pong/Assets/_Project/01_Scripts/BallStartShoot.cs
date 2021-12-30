using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class BallStartShoot : MonoBehaviour
    {
        BallSideControl _sideControl;
        BallSpeed _speed;
        Rigidbody _rigidbody;
        PlayerInput _controls;
        
        bool _canShoot;

        void Awake()
        {
            _sideControl = GetComponent<BallSideControl>();
            _speed = GetComponent<BallSpeed>();
            _rigidbody = GetComponent<Rigidbody>();
            _controls = new PlayerInput();
        }
        void OnEnable() => _controls.Enable();
        void Start()
        {
            _controls.WASD.Shoot.performed += _ => Shoot(Paddle.Left);
            _controls.Arrows.Shoot.performed += _ => Shoot(Paddle.Right);
            AllowToShoot();
        }
        void OnDisable() => _controls.Disable();

        void OnDestroy()
        {
            if (_controls == null) return;
            _controls.WASD.Shoot.performed -= _ => Shoot(Paddle.Left);
            _controls.Arrows.Shoot.performed -= _ => Shoot(Paddle.Right);
        }

        void Shoot(Paddle side)
        {
            if (!_canShoot) return;
            if (side != _sideControl.ControlSide) return;

            int xDir = 0;
            if (side == Paddle.Left) xDir = 1;
            if (side == Paddle.Right) xDir = -1;
                
            var direction = new Vector3(Random.value * xDir, 0f, Random.Range(-1f,1f)).normalized;
            _rigidbody.velocity = direction * _speed.InitialSpeed;

            _canShoot = false;
        }
        [ContextMenu("allow to Shoot")]
        public void AllowToShoot() => _canShoot = true;
        
    }
}
