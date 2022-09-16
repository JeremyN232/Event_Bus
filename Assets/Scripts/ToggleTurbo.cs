namespace Chapter.Command
{
    public class ToggleTurbo : Command
    {
        private BikeController1 _controller;

        public ToggleTurbo(BikeController1 controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.ToggleTurbo();
        }
    }
}
