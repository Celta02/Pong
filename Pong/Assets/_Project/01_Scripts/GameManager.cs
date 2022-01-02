using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] GameObject _ball;
        [SerializeField] PlayerController _leftController;
        [SerializeField] PlayerController _rightController;


        [SerializeField] int _touchesToIncreaseSpeed;
        [SerializeField] float _speedIncrease;
        
        
        BallSpeed _speed;
        BallStartShoot _shoot;
        
        //ScoreManager _scoreManager;
        SideControl _sideControl;
        BallRespawn _respawn;

        int _numberOfTouches;

        void Awake()
        {
            //_scoreManager = GetComponent<ScoreManager>();
            _respawn = GetComponent<BallRespawn>();
            _sideControl = GetComponent<SideControl>();
            _speed = _ball.GetComponent<BallSpeed>();
            _shoot = _ball.GetComponent<BallStartShoot>();
        }

        void Start() => InitializeGame();

        void InitializeGame()
        {
           _respawn.Respawn(_sideControl.ControlSide);
            StartGame();
        }

        public void StartGame()
        {
            _shoot.SubscribeTo(_leftController);
            _shoot.SubscribeTo(_rightController);
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