using GameEditor.Globals;

namespace GameEditor.Components.Interfaces
{

    public class WindowsCamera : ICamera
    {

        public int ID { get; set; } = GameComponentGlobals.NewID();

        public void Render()
        {
            Console.Write("Windows Camera");
        }

        public void CaptureFrame()
        {
            Console.Write("Windows - Filming Scene");
        }
    }

}

