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
    public static void GetHelpTune()
        {
            Console.WriteLine("Mit tune kann man Töne abspielen:");
            Console.WriteLine("Auf Windows kann man die Tonhöhe und länge anpassen: ");
            Console.WriteLine("Syntax: tune [tonhöhe] [tonlänge] [oktave]");
            Console.WriteLine("Für die Tonhöhe und Tonlänge gibt es ein paar Presets:");
            Console.WriteLine("Ohne Parameter spielt es die Tonhöhe/frequenz 277 = Musik chord C# und die länge 400 (entspricht einer viertelsnote)");
            Console.WriteLine("Als Parameter gibt es die Präfix = Tonhöhe (hz) = bezeichnung:  ");
            Console.WriteLine("1  =  262 = C, 2 = 277 = C#,");
            Console.WriteLine("3 = 294 = D,4 =  311 = D#, 5 = 330 = E,");
            Console.WriteLine("6 = 349 = F, 7 = 370 = F#, 8 = 392 = G, 9 = 415 = G#");
            Console.WriteLine("10 = A = 440, 11 = A# = 466, 12 = H(Englisch B) = 493 ");
            Console.WriteLine("Präfix = Tonlänge (ms) = bezeichnung: ");
            Console.WriteLine("1  = 1600 = ganzenote, 2 = 800 = halbenote, 4 = 400 = viertelsnote, 8 = 200 = achtelsnote, 16 = 100 =sechszehntelsnote  ");
            Console.WriteLine("Auf anderen Platformen wird eine Fehlermeldung erscheinen. ");
            Console.WriteLine("Oktaven: erste Oktave (C/C2) = 0.25, zweite Oktave c/C3 = 0.5, dritte Oktave (c'/C3) = 1, vierte Oktave (c''/C4) = 2, fünfte Oktave (c'''/C5) = 4 etc.  ");
        }
    }
}
