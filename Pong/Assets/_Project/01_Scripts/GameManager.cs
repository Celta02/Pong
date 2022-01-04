using System;
using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] GameObject _ball;
        [SerializeField] GameObject _leftPaddle;
        [SerializeField] GameObject _rightPaddle;

        [SerializeField] int _touchesToIncreaseSpeed;
        [SerializeField] float _speedIncrease;
        
        BallSpeed _speed;
        BallStartShoot _shoot;
        
        SideControl _sideControl;
        BallRespawn _respawn;

        Controls _letControl;
        Controls _rightControl;

        int _numberOfTouches;

        public Controls LetControl { set => _letControl = value; }
        public Controls RightControl { set => _rightControl = value; }

        void Awake()
        {
            _respawn = GetComponent<BallRespawn>();
            _sideControl = GetComponent<SideControl>();
            _speed = _ball.GetComponent<BallSpeed>();
            _shoot = _ball.GetComponent<BallStartShoot>();
        }

        void Start() => InitializeGame();

        void InitializeGame()
        {
            Time.timeScale = 0f;
           _respawn.Respawn(_sideControl.ControlSide);
        }

        public void StartGame()
        {
            AddController(true);
            AddController(false);

            if (!TryGetComponent(out PlayerController leftController)) return;
            _shoot.SubscribeTo(leftController);
            if (!TryGetComponent(out PlayerController rightController)) return;
            _shoot.SubscribeTo(rightController);

            Time.timeScale = 1f;
            Debug.Log($"Timescale is {Time.timeScale}");
        }

        void AddController(bool isLeft)
        {
            var control = isLeft ? _letControl : _rightControl;
            
            switch (control)
            {
                case Controls.AiControl:
                    if (isLeft) _leftPaddle.AddComponent<AIController>(); 
                    else _rightPaddle.AddComponent<AIController>();
                    break;
                case Controls.Wasd:
                    if (isLeft) _leftPaddle.AddComponent<PlayerWasdController>(); 
                    else _rightPaddle.AddComponent<PlayerWasdController>();
                    break;
                case Controls.Arrows:
                    if (isLeft) _leftPaddle.AddComponent<PlayerArrowsController>(); 
                    else _rightPaddle.AddComponent<PlayerArrowsController>();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Touch()
        {
            _numberOfTouches++;
            if(_numberOfTouches > _touchesToIncreaseSpeed)
                _speed.AugmentSpeed(_speedIncrease);
        }

        public void ResetTouches() => _numberOfTouches = 0;
        
        public void QuitGame() => Application.Quit();
    }
    
}