using System;
using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class Goal : MonoBehaviour
    {
        [SerializeField] Paddle _side;
        [SerializeField] ScoreManager _scoreManager;
        [SerializeField] BallRespawn _respawn;

        void OnTriggerEnter(Collider other)
        {
            _scoreManager.Goal(_side);
            _respawn.Respawn(_side);
        }
    }
}
