namespace CeltaGames._Project._01_Scripts
{
    public class PlayerArrowsController : PlayerController
    {
        Paddle _side = Paddle.Right;
        protected override void SubscribeShoot() => Controls.Arrows.Shoot.performed += _ => Shoot(_side);

        protected override float ReadValue() => Controls.Arrows.PaddleMove.ReadValue<float>();
    }
}