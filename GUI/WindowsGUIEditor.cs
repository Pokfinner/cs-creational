using GameEditor.Configs;

namespace GameEditor.GUIEditor
{
    public class WindowsGUIEditor : GUIEditor
    {
        public WindowsGUIEditor() : base() { }

        public override void DisplayGUI()
        {

            // GUI Editor
            do
            {
                Console.WriteLine("WINDOWS EDITOR - Create your Game.");
                Console.WriteLine("b) New Button");
                Console.WriteLine("c) New Camera");
                Console.WriteLine("g) New Game Component");
                Console.WriteLine("s) Start Game");
                _option = Console.ReadLine() ?? "";

                var config = new ComponentConfiguration();

                switch (_option)
                {
                    case "b":
                        Console.WriteLine("Button Text:");
                        config.Text = Console.ReadLine() ?? "";
                        Console.WriteLine("Button Color:");
                        config.Color = Console.ReadLine() ?? "";
                        config.Type = "Button";
                        configs.Add(config);
                        break;
                    case "c":
                        config.Type = "Camera";
                        configs.Add(config);
                        break;
                    case "g":
                        config.Type = "Component";
                        configs.Add(config);
                        break;
                    case "s":
                        break;
                    default:
                        throw new InvalidOperationException("Wrong Configuration Type");
                }



            } while (!_option.Equals("s"));

        }

    }
}