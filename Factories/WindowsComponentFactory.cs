using GameEditor.Components.Interfaces;

namespace GameEditor.Factories
{
    public class WindowsComponentFactory : IGameComponentFactory
    {
        public IGameComponent CreateGameComponent()
        {
            return new WindowsGameComponent();
        }

        public ICamera CreateCamera()
        {
            return new WindowsCamera();
        }

        public ILight CreateLight()
        {
            return new WindowsLight();
        }

        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public IText CreateText()
        {
            return new WindowsText();
        }
    }
}