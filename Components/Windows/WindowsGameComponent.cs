using GameEditor.Globals;

namespace GameEditor.Components.Interfaces
{

    public class WindowsGameComponent : IGameComponent
    {

        public int ID { get; set; } = GameComponentGlobals.NewID();

        public void Render()
        {
            Console.Write("Windows Game Component");
        }
    }

}

