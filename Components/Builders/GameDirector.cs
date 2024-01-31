using GameEditor.Components.Interfaces;
using GameEditor.Factories;
using GameEditor.Configs;

namespace GameEditor.Builders
{
    public class GameDirector
    {

        public void Construct(GameBuilder builder, IGameComponentFactory factory, IEnumerable<ComponentConfiguration> configurations)
        {
            foreach (var config in configurations)
            {
                var component = CreateComponent(config, factory);
                builder.AddComponent(component);
            }
        }

        private IGameComponent CreateComponent(ComponentConfiguration componentConfig, IGameComponentFactory _factory)
        {

            IGameComponent component;

            switch (componentConfig.Type)
            {
                case "Button":
                    var button = _factory.CreateButton();
                    button.Text = componentConfig.Text;
                    button.Color = componentConfig.Color;
                    component = button;
                    break;
                case "Camera":
                    var camera = _factory.CreateCamera();
                    component = camera;
                    break;
                case "Component":
                    var gComponent = _factory.CreateGameComponent();
                    component = gComponent;
                    break;
                default:
                    throw new InvalidOperationException("Wrong Configuration Type");
            }

            return component;

        }


    }
}