using System;
using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class Goal : MonoBehaviour
    {
        [SerializeField] Paddle _side;
        [SerializeField] ScoreManager _scoreManager;

        void OnTriggerEnter(Collider other) => _scoreManager.Goal(_side);
    }
}
