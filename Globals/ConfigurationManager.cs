namespace GameEditor.Globals
{
    public class ConfigurationManager{

        private static readonly ConfigurationManager _instance = new();

        public static ConfigurationManager Instance
        {
            get{
                return _instance;
            }
        }

        public string Theme {get; set;} = "Dark";
        public string Language {get; set;} = "English";
        public string OS {get; set;} = "Windows";

        public void LoadConfiguration(){
            Theme = "Dark";
            Language = "English";

            Console.WriteLine("Please select your OS. {Windows|macOS}");
            switch(Console.ReadLine()){
                case "Windows":
                case "windows":
                    OS = "windows";
                    break;
                case "MacOS":
                case "macOS":
                case "macos":
                    OS = "macos";
                    break;
                default:
                    throw new ArgumentException("Invalid OS");
            }
        }
    }
}   