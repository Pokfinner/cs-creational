namespace GameEditor.Components.Interfaces
{
    public interface IButton : IGameComponent
    {
        string? Text { get; set; }
        string? Color { get; set; }
    }
}
