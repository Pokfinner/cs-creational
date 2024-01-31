using GameEditor.Components.Interfaces;

namespace GameEditor.Factories
{
    public interface IGameComponentFactory
    {
        IGameComponent CreateGameComponent();
        ICamera CreateCamera();
        IButton CreateButton();
    }
}