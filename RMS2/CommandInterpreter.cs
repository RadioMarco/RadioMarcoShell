using Marcoshell.amatrix;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;


namespace RMS2
{
    internal class CommandInterpreter
    {
        public static string interpret(string[] command)
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
                        return "-2 shutdown";
                    }
                case "log":
                    {
                        Log.Message(StringTransformationTools.StringResasembler(command));
                        break;
                    }
                case "print":
                    {
                        Console.WriteLine(StringTransformationTools.StringResasembler(command));
                        break;
                    }
                case "wait":
                    {
                        Wait.waitInterpret(command);
                        break;
                    }
                case "time":
                    timecalcres.time.timeInterpreter(command);
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
                            ChangeDirectory.SetPath(StringTransformationTools.StringResasembler(command));
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
                            ChangeDirectory.MakeDirectory(StringTransformationTools.StringResasembler(command));
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
                            ChangeDirectory.RemoveDirectory(StringTransformationTools.StringResasembler(command));
                        break;

                    }
                case "run":
                    WindowsCommandLineIntegration.Run(command);
                    
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
                        Matrix101.Matrix(StringTransformationTools.StringToInt(command[1]));
                    }
                    break;
                case "color":
                    if (command.Length < 2)
                    {
                        Error.throwTooLittleArgumentError(command, "color (according to C# official Enumeration");
                        break;
                    }
                    else if (command.Length < 3)
                    {
                        ColorChange.ChangeConsoleColor(StringTransformationTools.StringToInt(command[1]));
                        break;
                    }
                    else
                    {
                        ColorChange.ChangeConsoleColor(StringTransformationTools.StringToInt(command[1]), StringTransformationTools.StringToInt(command[2]));
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
                default:
                    return "-1 failed";
                
                
            }
            return "0 success";
        }
        public static string[] RepeaterChecker(string[] command)
        {
            bool repeaterMark = false;
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == "!!")
                {
                    repeaterMark = true;
                    string oldPath = Directory.GetCurrentDirectory();
                    Directory.SetCurrentDirectory(Program.initialPath);
                    string[] commandList = File.ReadAllLines("commands.rmsl");
                    Directory.SetCurrentDirectory(oldPath);
                    command[i] = commandList[commandList.Length - 2];
                    
                }
            }
            if (repeaterMark)
            {
                string reasembled = StringTransformationTools.StringResasembler(command, 0);

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
