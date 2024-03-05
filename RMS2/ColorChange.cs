using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
    internal class ColorChange
    {
        public static void ChangeConsoleColor(int foreground,int background = 0)
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
    }
}
