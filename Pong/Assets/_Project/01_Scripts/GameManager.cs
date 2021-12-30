using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class GameManager : MonoBehaviour
    {
        ScoreManager _scoreManager;

        void Awake()
        {
            _scoreManager = GetComponent<ScoreManager>();
        }
        
        
    }
}