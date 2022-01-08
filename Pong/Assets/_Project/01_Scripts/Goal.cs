using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class Goal : MonoBehaviour
    {
        [SerializeField] Paddle _side;
        [SerializeField] ScoreManager _scoreManager;
        [SerializeField] BallRespawn _respawn;
        [SerializeField] BallSfx _audio;

        void OnTriggerEnter(Collider other)
        {
            _audio.PlayGoal();
            _scoreManager.Goal(_side);
            _respawn.Respawn(_side);
        }
    }
}
