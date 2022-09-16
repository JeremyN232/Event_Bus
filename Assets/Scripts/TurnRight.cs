namespace Chapter.Command
{
    public class TurnRight : Command
    {
        private BikeController1 _controller;

        public TurnRight(BikeController1 controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(BikeController1.Direction.Right);
        }
    }
}
