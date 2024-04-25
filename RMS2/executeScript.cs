using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{/// <summary>
 /// Diese Klasse lässt ein Skript, welches du selber schreiben kannst erstellen.
 /// </summary>
    internal class ExecuteScript
    {
        public static void Execution(string file)
        {
            try
            {
                string[] commands = File.ReadAllLines(file);
                foreach (var command in commands)
                {
                    string[] dividedCommand = command.ToLower().Split(' ');
                    string response = CommandInterpreter.interpret(CommandInterpreter.RepeaterChecker(dividedCommand,true));
                    if (response == "-1 failed")
                    {
                        Error.throwCommandError(command);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Error.throwUnautohrizedAccess(file);
            }
            catch (UnauthorizedAccessException)
            {
                Error.throwUnautohrizedAccess(file);
            }

            
        }
    }
}
