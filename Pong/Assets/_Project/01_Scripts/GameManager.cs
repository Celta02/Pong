using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] BallSpeed _speed;


        [SerializeField] int _touchesToIncreaseSpeed;
        [SerializeField] float _speedIncrease;
        
        //ScoreManager _scoreManager;

        int _numberOfTouches;

        void Awake()
        {
            //_scoreManager = GetComponent<ScoreManager>();
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