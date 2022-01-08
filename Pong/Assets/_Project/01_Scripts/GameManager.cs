using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] GameObject _gameElements;
        [SerializeField] GameObject _ball;
        [SerializeField] int _touchesToIncreaseSpeed;
        [SerializeField] float _speedIncrease;
        
        ControllerManager _controller;
        BallSpeed _speed;
        SideControl _sideControl;
        BallRespawn _respawn;

        int _numberOfTouches;

        void Awake()
        {
            _controller = GetComponent<ControllerManager>();
            _respawn = GetComponent<BallRespawn>();
            _sideControl = GetComponent<SideControl>();
            _speed = _ball.GetComponent<BallSpeed>();
        }
        
        public void StartGame()
        {
            _gameElements.SetActive(true);
           _respawn.Respawn(_sideControl.ControlSide);
           _controller.StartGame();
        }

        public void Touch()
        {
            _numberOfTouches++;
            if (_numberOfTouches <= _touchesToIncreaseSpeed) return;
            _speed.AugmentSpeed(_speedIncrease);
        }

        public void ResetTouches() => _numberOfTouches = 0;
        
        public void QuitGame() => Application.Quit();
    }
}