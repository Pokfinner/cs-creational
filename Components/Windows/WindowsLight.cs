namespace GameEditor.Components.Interfaces
{

    public class WindowsLight : ILight
    {

        public int ID { get; set; }
        public bool isOn = true;

        public void Render()
        {
            Console.Write($"Windows Light");
        }

        public void Illuminate()
        {
            Console.Write($"Windows - {(isOn ? "On" : "Off")} Light");
        }

        public void Toggle(){
            isOn = !isOn;
        }
    }

}

