using GameEditor.Components.Interfaces;

namespace GameEditor.Builders
{

    public class GameBuilder
    {

        private Game _game;

        public GameBuilder()
        {
            _game = new Game();
        }

        public void AddComponent(IGameComponent component)
        {
            _game.AddComponent(component);
        }

        public Game Build()
        {
            return _game;
        }



    }

}