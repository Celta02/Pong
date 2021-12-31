using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace CeltaGames._Project._01_Scripts
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] BallSpeed _speed;


        [SerializeField] int _touchesToIncreaseSpeed;
        [SerializeField] float _speedIncrease;
        
        //ScoreManager _scoreManager;
        SideControl _sideControl;
        BallRespawn _respawn;

        int _numberOfTouches;

        void Awake()
        {
            //_scoreManager = GetComponent<ScoreManager>();
            _respawn = GetComponent<BallRespawn>();
            _sideControl = GetComponent<SideControl>();
        }

        void Start() => InitializeGame();

        void InitializeGame()
        {
           _respawn.Respawn(_sideControl.ControlSide);
            
            
        }


        public void Touch()
        {
            _numberOfTouches++;
            if(_numberOfTouches > _touchesToIncreaseSpeed)
                _speed.AugmentSpeed(_speedIncrease);
        }

        public void ResetTouches() => _numberOfTouches = 0;
    }
}