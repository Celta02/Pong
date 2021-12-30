using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class BallStartShoot : MonoBehaviour
    {
        [SerializeField] float _speed;
        
        BallSideControl _sideControl;
        Rigidbody _rigidbody;
        PlayerInput _controls;
        
        bool _canShoot;

        void Awake()
        {
            _sideControl = GetComponent<BallSideControl>();
            _rigidbody = GetComponent<Rigidbody>();
            _controls = new PlayerInput();
        }
        void OnEnable() => _controls.Enable();
        void Start()
        {
            _controls.WASD.Shoot.performed += _ => Shoot(Paddle.Left);
            _controls.Arrows.Shoot.performed += _ => Shoot(Paddle.Right);
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
            Debug.Log("Shooting");
            if (!_canShoot) return;
            if (side != _sideControl.ControlSide) return;
            Debug.Log("Ball shooted");
            int xDir = 0;
            if (side == Paddle.Left) xDir = 1;
            if (side == Paddle.Right) xDir = -1;
                
            var direction = new Vector3(Random.value * xDir, 0f, Random.Range(-1f,1f));
            _rigidbody.velocity = direction * _speed;

            _canShoot = false;
        }
        [ContextMenu("allow to Shoot")]
        public void AllowToShoot() => _canShoot = true;
        
    }
}
