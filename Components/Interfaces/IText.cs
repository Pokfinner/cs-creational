namespace GameEditor.Components.Interfaces
{
    public interface IText : IGameComponent
    {
        string? Text { get; set; }
        string? Color { get; set; }
    }
}
