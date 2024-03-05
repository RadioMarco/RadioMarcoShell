using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
    internal class WindowsCommandLineIntegration
    {
        public static void Run(string[] command)
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
                        Process.Start(command[1], StringTransformationTools.StringResasembler(command,2));
                    }

                    
                }
            }
            catch (System.ComponentModel.Win32Exception)
            {
                Console.WriteLine("");
                Error.throwCustomError("RMS2: The Command can't be executed. Windows doesn't recognize it.");
            }
            Console.WriteLine("RMS2: ");
        }
        public static void OpenInExplorer(string location)
        {
            Process.Start("explorer.exe",location);
        }
    }
}
