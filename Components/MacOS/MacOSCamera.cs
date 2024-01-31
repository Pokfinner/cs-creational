namespace GameEditor.Components.Interfaces
{

    public class MacOSCamera : ICamera
    {

        public int ID { get; set; }

        public void Render()
        {
            Console.Write($"MacOS Camera");
        }

        public void CaptureFrame()
        {
            Console.Write("MacOS - Filming Scene");
        }
    }

}

