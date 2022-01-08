using System;
using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class ControllerManager : MonoBehaviour
    {
        [SerializeField] GameObject _ball;
        [SerializeField] GameObject _leftPaddle;
        [SerializeField] GameObject _rightPaddle;
        
        BallStartShoot _shoot;
        
        Controls _leftControl;
        Controls _rightControl;
        
        public Controls LeftControl { set => _leftControl = value; }
        public Controls RightControl { set => _rightControl = value; }

        void Awake() => _shoot = _ball.GetComponent<BallStartShoot>();

        public void StartGame()
        {
            AddController(true);
            AddController(false);

            if (!_leftPaddle.TryGetComponent( out PlayerController leftController)) return;
            _shoot.SubscribeTo(leftController);
            if (!_rightPaddle.TryGetComponent(out PlayerController rightController)) return;
            _shoot.SubscribeTo(rightController);
        }

        void AddController(bool isLeft)
        {
            var control = isLeft ? _leftControl : _rightControl;
            
            switch (control)
            {
                case Controls.AiControl:
                    if (isLeft)
                    {
                        _leftPaddle.AddComponent<AIController>();
                        _shoot.IsLeftAI = true;
                    }
                    else
                    {
                        _rightPaddle.AddComponent<AIController>();
                        _shoot.IsRightAI = true;
                    }
                    break;
                case Controls.Wasd:
                    if (isLeft)
                    {
                        _leftPaddle.AddComponent<PlayerWasdController>();
                        _shoot.IsLeftAI = false;
                    }
                    else
                    {
                        _rightPaddle.AddComponent<PlayerWasdController>();
                        _shoot.IsRightAI = false;
                    }
                    break;
                case Controls.Arrows:
                    if (isLeft)
                    {
                        _leftPaddle.AddComponent<PlayerArrowsController>();
                        _shoot.IsLeftAI = false;
                    }
                    else
                    {
                        _rightPaddle.AddComponent<PlayerArrowsController>();
                        _shoot.IsRightAI = false;
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
        
    }
}