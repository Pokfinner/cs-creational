namespace GameEditor.Components.Interfaces
{

    public class MacOSCamera : ICamera
    {

        public int ID { get; set; }

        public void Render()
        {
            Console.WriteLine($"MacOS Camera");
        }

        public void CaptureFrame()
        {
            Console.WriteLine("MacOS - Filming Scene");
        }
    }

}

