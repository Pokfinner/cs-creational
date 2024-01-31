using System;
using GameEditor.Configs;

namespace GameEditor.GUIEditor
{
    public class WindowsGUIEditor : GUIEditor
    {
        private int selectedIndex = 0;
        private string[] options = { "New Button", "New Camera", "New Light", "New Text", "New Game Component", "Start Game" };

        public WindowsGUIEditor() : base() { }

        private void DisplayOptions()
        {
            Console.Clear();
            Console.WriteLine("Windows EDITOR - Create your Game.");
            for (int i = 0; i < options.Length; i++)
            {
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(options[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(options[i]);
                }
            }
        }

        public override void DisplayGUI()
        {
            ConsoleKeyInfo keyInfo;
            bool continueEditing = true;

            do
            {
                DisplayOptions();
                keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    selectedIndex = (selectedIndex > 0) ? selectedIndex - 1 : options.Length - 1;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    selectedIndex = (selectedIndex + 1) % options.Length;
                }

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    continueEditing = ExecuteSelectedOption();
                }

            } while (continueEditing);


        }

        private bool ExecuteSelectedOption()
        {
            var config = new ComponentConfiguration();
            switch (selectedIndex)
            {
                case 0: // New Button
                    Console.WriteLine("Button Text:");
                    config.Text = Console.ReadLine() ?? "";
                    Console.WriteLine("Button Color:");
                    config.Color = Console.ReadLine() ?? "";
                    config.Type = "Button";
                    configs.Add(config);
                    Console.WriteLine("New Button created.");
                    break;
                case 1: // New Camera
                    config.Type = "Camera";
                    configs.Add(config);
                    Console.WriteLine("New Camera created.");
                    break;
                case 2: // New Light
                    config.Type = "Light";
                    configs.Add(config);
                    Console.WriteLine("New Light created.");
                    break;
                case 3: // New Text
                    Console.WriteLine("Text:");
                    config.Text = Console.ReadLine() ?? "";
                    Console.WriteLine("Text Color:");
                    config.Color = Console.ReadLine() ?? "";
                    config.Type = "Text";
                    configs.Add(config);
                    Console.WriteLine("New Text created.");
                    break;
                case 4: // New Game Component
                    config.Type = "Component";
                    configs.Add(config);
                    Console.WriteLine("New Game Component created.");
                    break;
                case 5: // Start Game
                    Console.WriteLine("Starting the game...");
                    return false;
            }
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            
            return true;
        }
    }
}
