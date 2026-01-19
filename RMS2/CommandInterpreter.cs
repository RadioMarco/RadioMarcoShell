using Marcoshell.amatrix;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;
namespace RMS2
{
    /// <summary>
    /// This is the interpreter of the command line/language.
    /// </summary>
    internal class CommandInterpreter
    {
        public static string interpret(string[] command,bool isExecutedAsScript = false)
        {
            switch (command[0])
            {
                //comments indicators
                case "":
                case "#":
                    {
                        break;
                    }
                //help command, shows a list of commands
                case "hp":
                case "help":
                case "show-commands":
                    {
                        Help.GetCommands();
                        break;
                    }
                //quits the programm
                case "exit":
                    {
                        //if (!isExecutedAsScript)
                        //return "-2 shutdown";
                        Console.WriteLine("Console will shutdown");
                        Thread.Sleep(1000);
                        Log.Message("stop");
                        Environment.Exit(0);
                           break;
                    }
                //writes someting in a log
                case "log":
                    {
                        if (command.Length > 1)
                        {
                            Log.Message(StringTools.StringResasembler(command));
                            break;
                        }
                        else
                            Error.throwTooLittleArgumentError(command, "message");
                        break;
                    }
                //Prints a String into the CLI
                case "echo":
                case "print":
                    {
                        Console.WriteLine(StringTools.StringResasembler(command));
                        break;
                    }
                //makes the programm wait for a set of Seconds
                case "wait":
                case "sleep":
                    {
                        Wait.waitInterpret(command);
                        break;
                    }
                //has different functions around the topic of time
                case "time":
                   string response =  timecalcres.Time.timeInterpreter(command);
                    if (response == "-1 failed")
                        return response;
                    Console.WriteLine($"{response}");
                    break;  //varwrite
                //shows the files in the directory
                case "ls":
                case "la":
                case "list":
                    {
                        Explorer.ListAll(Directory.GetCurrentDirectory());
                        break;
                    }
                //converts one Unit into an other
                case "convert":
                    {
                        if (command.Length < 4)
                        {
                            Error.throwTooLittleArgumentError(command, "startunit, endunit, startunitvalue");
                            return "-1 failed";
                            
                        }
                        Console.WriteLine(Converter.ConverterInterpreter(command[1], command[2], command[3]));
                        break;
                    } //varwrite
                //clears the cli, with title <string(default: #Radio Marco)> sets a custom Text
                case "cl":
                case "clear":
                    {
                        Console.Clear();
                        if (command.Length > 1 && command[1] == "title")
                        {
                            if (command.Length > 2)
                                StartUp.Title(StringTools.StringResasembler(command,2));
                            else
                                StartUp.Title();
                        }
                        break;
                    }
                // reads a file
                case "cat":
                case "read":
                    {
                        if (command.Length < 2)
                        {
                            Error.throwTooLittleArgumentError(command, "path");
                            return "-1 failed";
                        }
                        else
                            ReadFile.read(command[1]);
                        break;

                    }
                //changes the current working directory
                case "cd":
                case "changedirectory":
                    {
                        if (command.Length < 2)
                        {
                            Error.throwTooLittleArgumentError(command, "path");
                            return "-1 failed";
                        }
                        else
                            Explorer.SetPath(StringTools.StringResasembler(command));
                        break;

                    }
                // makes a new directory
                case "mkdir":
                case "makedirectory":
                    {
                        if (command.Length < 2)
                        {
                            Error.throwTooLittleArgumentError(command, "path");
                            return "-1 failed";
                        }
                        else
                            Explorer.MakeDirectory(StringTools.StringResasembler(command));
                        break;

                    }
                //removes a file or an Directory (with -r with files) used to be two commands
                case "rmdir":
                case "del":
                case "rm":
                case "removedirectory":
                case "removefile":
                case "remove":

                    {
                        if (command.Length < 2)
                        {
                            Error.throwTooLittleArgumentError(command, "path");
                            return "-1 failed";
                        }
                        if (command.Length < 3)
                            Explorer.RemoveDirectoryOrFile(StringTools.StringResasembler(command));
                        else
                        {
                            if (command[1] == "-r") //deletes all childfolders and files
                            {
                                Explorer.RemoveDirectoryOrFile(StringTools.StringResasembler(command, 2), true);
                            }
                            else if (command[1] == "-f") //hides error Messages
                                Explorer.RemoveDirectoryOrFile(StringTools.StringResasembler(command, 2),false, true);
                            else if (command[1] == "-rf") //deletes all childfolders and files and also hides messages
                                Explorer.RemoveDirectoryOrFile(StringTools.StringResasembler(command, 2), true, true);

                            else
                            {
                                Explorer.RemoveDirectoryOrFile(StringTools.StringResasembler(command));
                            }
                        }
                        break;

                    }
                //executes a command in cmd.exe
                case "run":
                    if (!isExecutedAsScript)
                        WindowsCommandLineIntegration.Run(command);
                    else
                        WindowsCommandLineIntegration.Run(command, true);
                    
                    break;
                //changes the color of the Back- or Foreground of the cli
                case "colour":
                case "clr":
                case "color":
                    if (command.Length == 1)
                    {
                        Error.throwTooLittleArgumentError(command, "color (according to C# official Enumeration");
                        break;
                    }
                    else if (command.Length == 2)
                    {
                        if (command[1] == "help")
                            Help.GetHelpColor();

                        else
                            ColorChange.ChangeConsoleColor(StringTools.StringToInt(command[1], 15));
                        break;
                    }
                    else
                    {
                        if (command[1] == "theme")
                        {
                            ColorChange.ChangeConsoleColorTheme(command[2]);
                        }
                        else
                        {
                            ColorChange.ChangeConsoleColor(StringTools.StringToInt(command[1], 15), StringTools.StringToInt(command[2]));
                        }
                        break;
                    }
                // moves files from one dir. to an other.
                case "mv":
                case "movefile":
                    if (command.Length < 3)
                    {
                        Error.throwTooLittleArgumentError(command, "File/Destination");
                    }
                    else if (command.Length > 3)
                    {
                        Files.MoveFile(command[1], command[2], command[3]);
                    }
                    else
                    {
                        Files.MoveFile(command[1], command[2]);
                    }
                    break;
                // Opens a file in explorer.exe
                case "./":
                case "open":
                    if (command.Length == 1 || command[1] == "here")
                    {
                        WindowsCommandLineIntegration.OpenInExplorer(Directory.GetCurrentDirectory());
                    }
                    else
                    {
                        WindowsCommandLineIntegration.OpenInExplorer(command[1]);
                    }
                    break;
                // You can write at the end of a file. doesn't currently support editing pre existing text.
                case "nano":
                case "write":
                    {
                        if (command.Length < 2)
                        {
                            Error.throwTooLittleArgumentError(command, "path and text");
                        }
                        else
                        {
                            Files.WriteInFile(command);
                        }
                        break;
                    }
                //executes something in powershell.exe
                case "ps:":
                case "pwsh":
                case "ps":
                    {
                        WindowsCommandLineIntegration.RunInPowerShell(command);
                        break;
                    }
                //plays a sound
                case "tune":
                    {
                        if (command.Length < 2)
                        {
                            Tune.Play();
                        }
                        else if (command.Length < 3)
                        {
                            Tune.Play(command[1]);
                        }
                        else if (command.Length < 4)
                        {
                            Tune.Play(command[1],command[2]);
                        }
                        else
                        {
                            Tune.Play(command[1], command[2], command[3]); 
                        }
                        break;
                       
                    }
                // let's you interact with custom variales.
                case "var":
                    Variables.VarCommandInterpret(command);
                    break;
                //let's you execute your own scripts
                case "exe":
                    {
                        if (command.Length == 1)
                        {
                            Error.throwTooLittleArgumentError(command, "file");
                            return "-1 failed";
                        }
                        else
                            ExecuteScript.Execution(StringTools.StringResasembler(command));
                        break;
                    }
                // lookup something in the internet
                case "lookup":
                    {
                        if (command.Length > 1)
                        {
                            if (command[1] == "link")
                                if (command.Length > 2)
                                {
                                    WindowsCommandLineIntegration.OpenInExplorer($"https://{StringTools.StringResasembler(command, 2)}");
                                    break;
                                }
                            WindowsCommandLineIntegration.OpenInExplorer($"https://duckduckgo.com/{StringTools.StringResasembler(command)}");
                            break;
                        }
                        Error.throwTooLittleArgumentError(command, "query");
                        break;
                    }
                //does currently nothing, planned to grant you admin priviledges.
                case "sudo":
                    {
                        break;
                    }
                //easteregg commands
                case "thanks":
                    {
                        Console.WriteLine("No Problem :3");
                        break;
                    }
                case "gf":
                    {
                        Console.WriteLine("I don't have a GF, I'm still a virgin :(");
                        break;
                    }
                case "fu":{
                        Console.WriteLine("Don't be rude. I'm just doing my Job, if something doesn't work, it's entierly your fault!");
                            break;
                    }
                case "fuck":
                    {
                        Console.WriteLine("Problems can happen, don't worry.");
                            break;
                    }
                case "sudon't":
                    {
                        if (command.Length > 2 && StringTools.StringResasembler(command) == "make me a sandwich")
                        {
                            Error.throwCustomError("Proccess.Sudo.Sandwichcreation could not be started driver Sandwichmaker was not installed");
                        }
                        else
                        {
                            if (command.Length == 1)
                                Sudont.Say();
                            else
                                Sudont.Say(StringTools.StringToInt(command[1]));
                        }
                        break;
                    }
                case "_":
                    if (command.Length > 1 && command[1] == "<")
                        StartUp.Commandli();
                    break;
                case "amatrix":
                    if (command.Length < 2)
                    {
                        Matrix101.Matrix();
                    }
                    else if (command.Length < 3)
                    {
                        Matrix101.Matrix(StringTools.StringToInt(command[1]));
                    }
                    else
                    {
                        if (command[2] == "true")
                        {
                            Matrix101.Matrix(StringTools.StringToInt(command[1]),true);
                        }
                        else
                        {
                            Matrix101.Matrix(StringTools.StringToInt(command[1]));
                        }
                    }
                    break;
                
                default:
                    return "-1 failed";
                
                
            }
            return "0 success";
        }
        public static string[] RepeaterChecker(string[] command, bool isExecutedInAScript = false)
        {
            bool repeaterMark = false;
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == "!!")
                {
                    if (isExecutedInAScript)
                    {
                        Error.throwSkriptExecutionForbiden("!! interpreter");
                        command[i] = "";
                    }
                    else
                    {
                        repeaterMark = true;
                        string oldPath = Directory.GetCurrentDirectory();
                        string path = Environment.GetEnvironmentVariable("RMS2logs");
                        Directory.SetCurrentDirectory(path);
                        string[] commandList = File.ReadAllLines("commands.rmsl");
                        Directory.SetCurrentDirectory(oldPath);
                        command[i] = commandList[commandList.Length - 2];
                    }
                    
                }
            }
            if (repeaterMark)
            {
                string reasembled = StringTools.StringResasembler(command, 0);

                string[] output = reasembled.Split(' ');
                Console.WriteLine(reasembled);
                return output;
            }
            else {
                return command;
            }
        }
    }
}
