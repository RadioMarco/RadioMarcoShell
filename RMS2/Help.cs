namespace RMS2
{
    internal class Help
    {
        public static void GetHelp()
        {
            Console.WriteLine("List of all commands as of V. 2.0");
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
            Console.WriteLine("ps [powershell command]:             executes an Powershell command. (also works with ps:)");
            Console.WriteLine("tune* <tone> <duration> <octave>:    Plays a tune based on the given parameters. ");
            Console.WriteLine("exe [file]                           executes an RMSS(RadioMarcoShellScript) (RMSS made for version 1 may not work properly)");
            Console.WriteLine("*Complex command with many arguments [command] help for more informations");
            
        }
    public static void GetHelpTune()
        {
            Console.WriteLine("You can play sounds with tune <tone> <duration> <octave>:");
            Console.WriteLine("Without Parameters this program plays an C# (277hz) with a quarter duration (400ms) at the octave number three C3)");
            Console.WriteLine("This only Works on Windows: ");
            Console.WriteLine("<tone>:");
            Console.WriteLine("These sounds can be used (frequence hz):  ");
            Console.WriteLine("1  =  262 = C, 2 = 277 = C#,");
            Console.WriteLine("3 = 294 = D,4 =  311 = D#, 5 = 330 = E,");
            Console.WriteLine("6 = 349 = F, 7 = 370 = F#, 8 = 392 = G, 9 = 415 = G#");
            Console.WriteLine("10 = A = 440, 11 = A# = 466, 12 = B/H = 493 ");
            Console.WriteLine("duration (time ms): ");
            Console.WriteLine("1  = 1600 = full, 2 = 800 = half, 4 = 400 = quarter, 8 = 200 = eightth, 16 = 100 = sixteenth");
            Console.WriteLine("Oktaves: first Oktave (C/C2) = 0.25, second Oktave c/C3 = 0.5, third Oktave (c'/C3) = 1, fourth Oktave (c''/C4) = 2, fifth Oktave (c'''/C5) = 4 etc.  ");
        }
    public static void GetHelpColor()
        {
            Console.WriteLine("color [foreground] [background]");
            Console.WriteLine("The color coding is based on the C# color coding beeing: ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("0 for Black (default for the background)");
            Console.ForegroundColor = (ConsoleColor)1;
            Console.WriteLine("1 for DarkBlue");
            Console.ForegroundColor = (ConsoleColor)2;
            Console.WriteLine("2 for DarkGreen");
            Console.ForegroundColor = (ConsoleColor)3;
            Console.WriteLine("3 for DarkCyan");
            Console.ForegroundColor = (ConsoleColor)4;
            Console.WriteLine("4 for DarkRed");
            Console.ForegroundColor = (ConsoleColor)5;
            Console.WriteLine("5 for DarkMagenta");
            Console.ForegroundColor = (ConsoleColor)6;
            Console.WriteLine("6 for DarkYellow");
            Console.ForegroundColor = (ConsoleColor)8;
            Console.WriteLine("8 for DarkGray");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = (ConsoleColor)7;
            Console.WriteLine("7 for Gray/Grey (Yeah, I don't know either why Gray is assigned a lower value than DarkGray (swapped place for better visibility))");
            Console.ForegroundColor = (ConsoleColor)9;
            Console.WriteLine("9 for Blue");
            Console.ForegroundColor = (ConsoleColor)10;
            Console.WriteLine("10 for Green");
            Console.ForegroundColor = (ConsoleColor)11;
            Console.WriteLine("11 for Cyan");
            Console.ForegroundColor = (ConsoleColor)12;
            Console.WriteLine("12 for Red");
            Console.ForegroundColor = (ConsoleColor)13;
            Console.WriteLine("13 for Magenta");
            Console.ForegroundColor = (ConsoleColor)14;
            Console.WriteLine("14 for Yellow");
            Console.ForegroundColor = (ConsoleColor)15;
            Console.WriteLine("15 for White (default for the font)");
            Console.ForegroundColor = Program.foregroundColor;
            Console.BackgroundColor = Program.backgroundColor;

        }
    }
}
