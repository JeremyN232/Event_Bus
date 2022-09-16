namespace Chapter.Command
{
    public class TurnLeft : Command
    {
        private BikeController1 _controller;

        public TurnLeft(BikeController1 controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(BikeController1.Direction.Left);
        }
    }
}
