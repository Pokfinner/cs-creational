using System.Collections.Generic;
using GameEditor.Components.Interfaces;

namespace GameEditor.Builders
{

    public class Game
    {
        private List<IGameComponent> _components;

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
            foreach (var component in _components)
            {
                component.Render();
            }
        }
    }

}