using System.Collections.Generic;
using GameEditor.Components.Interfaces;
using GameEditor.Globals;

namespace GameEditor.Builders
{

    public class Game
    {
        private List<IGameComponent> _components;
        private string layout;

        public Game()
        {
            _components = new List<IGameComponent>();
        }

        public void AddComponent(IGameComponent component)
        {
            _components.Add(component);
        }

        public void Render()
        {
            Console.WriteLine($"--- Game in {ConfigurationManager.Instance.OS.ToUpper()} ---");
            Console.WriteLine($"--- {ConfigurationManager.Instance.layout} Layout ---");

            foreach (var component in _components)
            {
                component.Render();
                if (ConfigurationManager.Instance.layout.Equals("Vertical")){
                    Console.Write("\n");
                } else if (ConfigurationManager.Instance.layout.Equals("Horizontal")){
                    Console.Write("\t");
                }
            }
        }
    }

}