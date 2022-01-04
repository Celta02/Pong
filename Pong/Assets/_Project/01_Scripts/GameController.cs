using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public abstract class GameController : MonoBehaviour
    {
        protected PaddleMover Mover;
        protected virtual void Awake() => Mover = GetComponent<PaddleMover>();
        protected void MovePaddle(float value) => Mover.MovementInput = Mathf.Clamp(value,-1f,1f);
    }
}