using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
    internal class Help
    {
        public static void GetHelp()
        {
            Console.WriteLine("List of all commands as of V. 2.0.1 Beta");
            Console.WriteLine("please note that, due to the Codebase being changed, currently the legacy commands of V.1 aren't available. ");
            Console.WriteLine("help:                                Shows this list Predefined Alias: hp");
            Console.WriteLine("exit:                                Ends this programm.");
            Console.WriteLine("log [text]:                          Enables you to write anything into the Log. Ideal in the future for Skripts.");
            Console.WriteLine("print [text]:                        Lets you write anything on the console window. predefined Alias: echo");
            Console.WriteLine("wait [period]:                       The Console waits for a given amount of time.");
            Console.WriteLine("time*:                               A set of features about time. Please enter time help for more informations.");
            Console.WriteLine("list:                                Shows all files in the current directory. Predifined Alias: ls, la");
            Console.WriteLine("convert*:                            Converts a value from one unit to another.");
            Console.WriteLine("clear <title>:                       clears the content of the console windows. (title adds back title) Predefined Alias: cl");
            Console.WriteLine("read [file]:                         reads a file predefined Alias: cat ");
            Console.WriteLine("changedirectory [directory]:         change current working directory predefined Alias: cd");
            Console.WriteLine("makedirectory [directory]:           makes a new subdirectory in working directory predefined Alias: mkdir ");
            Console.WriteLine("removedirectory [directory]:         removes an EMPTY subdirectory in working directory. predefined Alias: rmdir");
            Console.WriteLine("run [command] [arguments]:           runs a Windows Commandline command (may not all work)");
            Console.WriteLine("color [foreground] [background]:     Changes fore- and background color. predefined Alias: colour, clr");
            Console.WriteLine("removefile [file]                    removes a file predefined Alias: rm");
            Console.WriteLine("movefile [file] [folder]:            moves a file predefined Alias: mv");
            Console.WriteLine("open <folder>:                       Opens a folder in explorer.exe predefined Alias: ./");
            Console.WriteLine("write [file] [text]:                 writes a given string on the bottom of a file. (if file doesn't exist it creates one) predefined Alias: nano");
            Console.WriteLine("*Complex command with many arguments [command] help for more informations");
            
        }
    }
}
