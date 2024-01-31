using GameEditor.Factories;
using GameEditor.Globals;
using GameEditor.Builders;
using GameEditor.GUIEditor;

class Program
{
    static void Main(string[] args)
    {

        // Singleton -> Configuração de um Game Engine para vários OS
        var configurationManager = ConfigurationManager.Instance;
        configurationManager.LoadConfiguration();

        // Abstract Factory -> Configuração de uma factory e um *conjunto* de Components dependendo do OS
        IGameComponentFactory factory = GetFactoryBasedOnOS();

        // Factory Method - Lançar *um* Editor Visual baseado no OS
        GUIEditor editor = GetGUIEditorBasedOnOS();
        editor.ConstructGUI();

        // Construir o Jogo
        var builder = new GameBuilder();
        var director = new GameDirector();

        director.Construct(
            builder,
            factory,
            editor.getConfigs()
        );

        Game game = builder.Build();

        // Correr o Jogo
        game.Render();
    }

    // Implementar Factory para Windows
    static IGameComponentFactory GetFactoryBasedOnOS()
    {
        Console.WriteLine(ConfigurationManager.Instance.OS);

        switch (ConfigurationManager.Instance.OS)
        {
            case "windows":
                return new WindowsComponentFactory();
            case "macos":
                return new MacOSComponentFactory();
            default:
                throw new InvalidOperationException("Wrong OS");
        }

    }

    static GUIEditor GetGUIEditorBasedOnOS()
    {
        switch (ConfigurationManager.Instance.OS)
        {
            case "windows":
                return new WindowsGUIEditor();
            case "macos":
                return new MacOSGUIEditor();
            default:
                throw new InvalidOperationException("Wrong OS");
        }
    }
}

