namespace CeltaGames._Project._01_Scripts
{
    public class PlayerWasdController : PlayerController
    {
        Paddle _side = Paddle.Left;
        protected override void SubscribeShoot() => Controls.WASD.Shoot.performed += _ => Shoot(_side);

        protected override float ReadValue() => Controls.WASD.PaddleMove.ReadValue<float>();
    }
}