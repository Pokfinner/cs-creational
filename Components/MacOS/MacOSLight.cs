namespace GameEditor.Components.Interfaces
{

    public class MacOSLight : ILight
    {

        public int ID { get; set; }
        public bool isOn = true;

        public void Render()
        {
            Console.Write($"MacOS Light");
        }

        public void Illuminate()
        {
            Console.Write($"MacOS - {(isOn ? "On" : "Off")} Light");
        }

        public void Toggle(){
            isOn = !isOn;
        }
    }

}

