namespace GameEditor.Globals
{
    
    public static class GameComponentGlobals
    {
        public static int _ID = 0;

        public static int NewID()
        {
            return ++_ID;
        }
    }

}
