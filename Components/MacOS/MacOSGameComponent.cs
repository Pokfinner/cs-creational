using GameEditor.Globals;

namespace GameEditor.Components.Interfaces
{

    public class MacOSGameComponent : IGameComponent
    {

        public int ID { get; set; } = GameComponentGlobals.NewID();

        public void Render()
        {
            Console.WriteLine("MacOS Game Component");
        }
    }

}

