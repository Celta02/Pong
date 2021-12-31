using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class BallRespawn : MonoBehaviour
    {
        [SerializeField] Transform _ball;

        Rigidbody _rigidbody;
        BallSideControl _sideControl;
        BallStartShoot _shoot;
        GameManager _gameManager;
        BallSpeed _speed;
        
        Vector3 _startPosition;

        void Awake()
        {
            _sideControl = _ball.GetComponent<BallSideControl>();
            _shoot = _ball.GetComponent<BallStartShoot>();
            _rigidbody = _ball.GetComponent<Rigidbody>();
            _speed = _ball.GetComponent<BallSpeed>();
            _gameManager = GetComponent<GameManager>();
        }

        void Start() => _startPosition = _ball.position;

        public void Respawn(Paddle sideThatStartsNewRound)
        {
            _ball.position = _startPosition;
            _rigidbody.velocity = Vector3.zero;
            _sideControl.GiveControlSide(sideThatStartsNewRound);
            _shoot.AllowToShoot();
            _gameManager.ResetTouches();
            _speed.ResetCurrentSpeed();
        }
        
    }
}
