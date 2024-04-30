using Marcoshell.amatrix;
using Windows.ApplicationModel.DataTransfer;

namespace RMS2
{
    /// <summary>
    /// Diese Klasse ist der Interpretter dîeser Skript sprache.
    /// </summary>
    internal class CommandInterpreter
    {
        public static string interpret(string[] command,bool isExecutedAsScript = false)
        {
            switch (aliasInterpret.commandTranslater(command[0]))
            {
                case "":
                    {
                        break;
                    }
                case "#":
                    {
                        break;
                    }
                case "help":
                    {
                        Help.GetHelp();
                        break;
                    }
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
                case "print":
                    {
                        Console.WriteLine(StringTools.StringResasembler(command));
                        break;
                    }
                case "wait":
                    {
                        Wait.waitInterpret(command);
                        break;
                    }
                case "time":
                   string response =  timecalcres.Time.timeInterpreter(command);
                    if (response == "-1 failed")
                        return response;
                    Console.WriteLine($"{response}");
                    break;
                case "list":
                    {
                        Explorer.ListAll(Directory.GetCurrentDirectory());
                        break;
                    }
                case "convert":
                    {
                        if (command.Length < 4)
                        {
                            Error.throwTooLittleArgumentError(command, "startunit, endunit, startunitvalue");
                            return "-1 failed";
                            
                        }
                        Console.WriteLine(Converter.ConverterInterpreter(command[1], command[2], command[3]));
                        break;
                    }
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
                case "removedirectory":
                    {
                        if (command.Length < 2)
                        {
                            Error.throwTooLittleArgumentError(command, "path");
                            return "-1 failed";
                        }
                        else
                            Explorer.RemoveDirectory(StringTools.StringResasembler(command));
                        break;

                    }
                case "run":
                    if (!isExecutedAsScript)
                        WindowsCommandLineIntegration.Run(command);
                    else
                        WindowsCommandLineIntegration.Run(command, true);
                    
                    break;
                case "_":
                    if (command.Length > 1 && command[1] == "<")
                        StartUp.Commandli();
                    break;
                case "amatrix":
                    if (command.Length < 2)
                    {
                        Matrix101.Matrix();
                    }
                    else
                    {
                        Matrix101.Matrix(StringTools.StringToInt(command[1]));
                    }
                    break;
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
                case "removefile":
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
                case "ps":
                    {
                        WindowsCommandLineIntegration.RunInPowerShell(command);
                        break;
                    }
                case "tune":
                    {
                        if (command.Length == 2)
                        {
                            if (command[1] == "help")
                            {
                                Help.GetHelpTune();
                            }
                            else
                            {
                                Tune.Play();
                            }
                        }
                        else if (command.Length == 3)
                        {
                            Tune.Play(command[1]);
                        }
                        else if (command.Length == 4)
                        {
                            Tune.Play(command[1], command[2]);
                        }
                        else
                        {
                            Tune.Play(command[1], command[2], command[3]);
                        }
                        break;
                    }
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
                case "fu":
                    {
                        Console.WriteLine("Don't be rude. I'm just doing my Job, if something doesn't work, it's entierly your fault!");
                            break;
                    }
                case "fuck":
                    {
                        Console.WriteLine("Problems can happen, don't worry.");
                            break;
                    }
                case "sudo":
                    {
                        if (command.Length > 2 && StringTools.StringResasembler(command) == "make me a sandwich")
                        {
                            Error.throwCustomError("Proccess.Sudo.Sandwichcreation could not be started driver Sandwichmaker was not installed");
                        }
                        else
                        {
                            if (command.Length == 1)
                                Sudo.Say();
                            else
                                Sudo.Say(StringTools.StringToInt(command[1]));
                        }
                        break;
                    }
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
                        Directory.SetCurrentDirectory(Program.initialPath);
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
