using GameEditor.Globals;

namespace GameEditor.Components.Interfaces
{

    public class WindowsCamera : ICamera
    {

        public int ID { get; set; } = GameComponentGlobals.NewID();

        public void Render()
        {
            Console.WriteLine("Windows Camera");
        }

        public void CaptureFrame()
        {
            Console.WriteLine("Windows - Filming Scene");
        }
    }

}

