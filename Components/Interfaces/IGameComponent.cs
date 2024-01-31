namespace GameEditor.Components.Interfaces
{
    public interface IGameComponent
    {
        int ID { get; set; }
        void Render();
    }
}
