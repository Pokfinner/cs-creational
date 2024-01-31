using GameEditor.Components.Interfaces;

namespace GameEditor.Factories
{
    public class MacOSComponentFactory : IGameComponentFactory
    {
        public IGameComponent CreateGameComponent(){
            return new MacOSGameComponent();
        }

        public ICamera CreateCamera(){
            return new MacOSCamera();
        }

        public IButton CreateButton(){
            return new MacOSButton();
        }
    }
}