using GameEditor.Globals;

namespace GameEditor.Components.Interfaces
{

    public class WindowsButton : IButton
    {

        public string? Text { get; set; } = string.Empty;
        public string? Color { get; set; } = string.Empty;
        public int ID { get; set; } = GameComponentGlobals.NewID();

        public void Render()
        {
            Console.WriteLine("Windows Button");
        }

    }

}

