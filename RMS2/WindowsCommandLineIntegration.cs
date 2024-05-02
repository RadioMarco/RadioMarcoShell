using System.Diagnostics;
using System.Runtime.Versioning;
namespace RMS2
{
    [SupportedOSPlatform("windows")]
    internal class WindowsCommandLineIntegration
    {
        public static void Run(string[] command,bool isinSkript = false)
        {
            //string oldDir = Directory.GetCurrentDirectory();
            //Directory.SetCurrentDirectory("C:\\");
            try
            {
                //string process = StringTransformationTools.StringResasembler(command);
                if (command[1] == "disapointment.exe")
                {
                    Console.WriteLine("RMS2: Live can be sometimes disapointing... :(");
                }
                else
                {
                    if (isinSkript)
                    {
                        if (command[1] == "shutdown")
                        {
                            Error.throwSkriptExecutionForbiden("run shutdown");
                            command[1] = "";
                        }
                    }
                    Console.Write("CMD: ");
                    if (command.Length == 2)
                    {
                        Process.Start(command[1]);
                    }
                    else if (command.Length == 3)
                    {
                        Process.Start(command[1], command[2]);
                    }
                    else if (command.Length > 3)
                    {
                        Process.Start(command[1], StringTools.StringResasembler(command,2));
                    }

                    
                }
            }
            catch (System.ComponentModel.Win32Exception)
            {
                Console.WriteLine("");
                Error.throwCustomError("RMS2: The Command can't be executed. Windows doesn't recognize it.");
            }
            Console.ReadKey();
            Console.WriteLine("RMS2: ");
        }
        public static void OpenInExplorer(string location)
        {
            Process.Start("explorer.exe",location);
        }
        public static void RunInPowerShell(string[] command)
        {
            Console.Write("PS: ");
            try
            {


                Process.Start("powershell.exe", StringTools.StringResasembler(command));
            }
            catch (System.ComponentModel.Win32Exception)
            {
                Console.WriteLine("");
                Error.throwCustomError("RMS2: The Command can't be executed. Windows doesn't recognize it.");
            }
            Console.ReadKey();
            Console.WriteLine("RMS2: ");
        }
    }
}
