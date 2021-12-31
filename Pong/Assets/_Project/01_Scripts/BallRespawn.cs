using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class BallRespawn : MonoBehaviour
    {
        [SerializeField] Transform _ball;
        [SerializeField] Transform _leftStart;
        [SerializeField] Transform _rightStart;

        Rigidbody _rigidbody;
        SideControl _sideControl;
        BallStartShoot _shoot;
        GameManager _gameManager;
        BallSpeed _speed;
        
        void Awake()
        {
            _shoot = _ball.GetComponent<BallStartShoot>();
            _rigidbody = _ball.GetComponent<Rigidbody>();
            _speed = _ball.GetComponent<BallSpeed>();
            _gameManager = GetComponent<GameManager>();
            _sideControl = GetComponent<SideControl>();
        }


        public void Respawn(Paddle sideThatStartsNewRound)
        {
            if(sideThatStartsNewRound == Paddle.Left)
                _ball.position = _leftStart.position;
            if(sideThatStartsNewRound == Paddle.Right)
                _ball.position = _rightStart.position;
            
            _rigidbody.velocity = Vector3.zero;
            _sideControl.GiveControlSide(sideThatStartsNewRound);
            _shoot.AllowToShoot();
            _shoot.AIShoot(sideThatStartsNewRound);
            _gameManager.ResetTouches();
            _speed.ResetCurrentSpeed();
        }
        
    }
}
