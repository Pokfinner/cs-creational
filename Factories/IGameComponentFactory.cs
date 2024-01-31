using GameEditor.Components.Interfaces;

namespace GameEditor.Factories
{
    public interface IGameComponentFactory
    {
        IGameComponent CreateGameComponent();
        ICamera CreateCamera();
        ILight CreateLight();
        IButton CreateButton();
        IText CreateText();
    }
}