using System.Collections.Generic;
using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class BallStartShoot : MonoBehaviour
    {
        [SerializeField] SideControl _sideControl;
        BallSpeed _speed;
        Rigidbody _rigidbody;
        bool _canShoot;

        readonly List<PlayerController> _controllers = new List<PlayerController>();
        
        void Awake()
        {
            _speed = GetComponent<BallSpeed>();
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void SubscribeTo(PlayerController controller)
        {
            controller.ControllerShoot += Shoot;
            _controllers.Add(controller);
        }

        void OnDisable()
        {
            foreach (var controller in _controllers)
                controller.ControllerShoot -= Shoot;
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
        public void AllowToShoot() => _canShoot = true;
    }
}
