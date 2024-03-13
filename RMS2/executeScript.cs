using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
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
                    string response = CommandInterpreter.interpret(CommandInterpreter.RepeaterChecker(dividedCommand));
                    if (response == "-1 failed")
                    {
                        Error.throwCommandError(command);
                    }
                    else if (response == "-2 shutdown")
                    {
                        Error.throwCustomError("For your safety, you can't shutdown the console, during a script");
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
