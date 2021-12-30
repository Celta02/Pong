using UnityEngine;

namespace CeltaGames._Project._01_Scripts
{
    public class BallSideControl : MonoBehaviour
    {
        Paddle _controlSide;
        public Paddle ControlSide => _controlSide;

        void Start() => GiveRandomControlSide();

        void GiveRandomControlSide() => _controlSide = Random.value > 0.5 ? Paddle.Left : Paddle.Right;

        public void SwitchControl() => _controlSide = _controlSide == Paddle.Left ? Paddle.Right : Paddle.Left;

        public void GiveControlSide(Paddle side) => _controlSide = side;
    }
}
