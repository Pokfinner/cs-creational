using GameEditor.Factories;
using GameEditor.Builders;
using GameEditor.Configs;

namespace GameEditor.GUIEditor
{
    public abstract class GUIEditor
    {
        protected static List<ComponentConfiguration> configs = new List<ComponentConfiguration>();
        protected string _option = "";

        public abstract void ConstructGUI();
        public List<ComponentConfiguration> getConfigs(){
            return configs;
        }

    }
}