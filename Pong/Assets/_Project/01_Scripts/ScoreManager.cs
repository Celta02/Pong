using System;
using TMPro;
using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class ScoreManager : MonoBehaviour
    {
        [SerializeField] int _pointsToVictory;
        
        [SerializeField] TMP_Text _leftScoreText;
        [SerializeField] TMP_Text _rightScoreText;

        int _leftScore = 0;
        int _rightScore = 0;
        readonly string _formatString = "00";

        void Start()
        {
            _leftScoreText.text = _leftScore.ToString(_formatString);
            _rightScoreText.text = _rightScore.ToString(_formatString);
        }

        public void Goal(Paddle side)
        {
            if (side == Paddle.Left)
            {
                _leftScore++;
                _leftScoreText.text = _leftScore.ToString(_formatString);
                if (CheckVictory(_leftScore))
                {
                    Debug.Log($"Victory Left");
                }
            }

            if (side == Paddle.Right)
            {
                _rightScore++;
                _rightScoreText.text = _rightScore.ToString(_formatString);
                if (CheckVictory(_rightScore))
                {
                    Debug.Log($"Victory Right");
                }
            }
        }

        bool CheckVictory(int leftScore) => leftScore > _pointsToVictory;
    }
}