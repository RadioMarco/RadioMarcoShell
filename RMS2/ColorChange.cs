namespace RMS2
{
    internal class ColorChange
    {
        public static void ChangeConsoleColor(int foreground = 15,int background = 0)
        {
            if (foreground > 15 || background > 15)
            {
                Error.throwArgumentError("color", "foreground or background");
            }
            else
            {

                Program.foregroundColor = (ConsoleColor)foreground;
                Program.backgroundColor = (ConsoleColor)background;
                Console.ForegroundColor = Program.foregroundColor;
                Console.BackgroundColor = Program.backgroundColor;
            }
        }
        public static void ChangeConsoleColorTheme(string theme = "") 
        {
           
            
         theme =  theme.ToLower();
            
            switch (theme)
            {
                case "matrix":
                    ChangeConsoleColor(10, 0);
                    break;
                case "white":
                    ChangeConsoleColor(0, 15);
                    break;
                case "communist":
                    ChangeConsoleColor(14, 4);
                    break;
                case "error":
                    ChangeConsoleColor(4, 0);
                    break;
                case "water":
                    ChangeConsoleColor(15, 9);
                    break;
                case "empty":
                    ChangeConsoleColor((int)Program.backgroundColor,(int)Program.backgroundColor);
                    break;
                default:
                    ChangeConsoleColor(15, 0);
                    break;
            }

        }
    }
}
