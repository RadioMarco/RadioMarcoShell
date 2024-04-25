using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
    /// <summary>
    /// Diese Klasse dient dazu, bei Fehlern die Nachrichten zu handeln.
    /// </summary>
    internal class Error
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public static void throwCommandError(string command = "none")
        {
            Log.Message($"Command {command} failed. ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"Command {command} failed. - Please Check the syntax, for more informations enter \"help\"");
            Console.WriteLine($"As of now, not all Legacy version 1 Commands are implementet. ");
            Console.ForegroundColor = Program.foregroundColor;
            Console.BackgroundColor = Program.backgroundColor;
        }
        public static void throwArgumentError(string command, string argument)
        {
            Log.Message($" Command {command} failed. Due to argument {argument} ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"Command {command} failed, Something went wrong with argument {argument}. - Please Check the syntax, for more informations enter \"help\"");
            Console.WriteLine($"As of now, not all Legacy version 1 Commands are implementet. ");
            Console.ForegroundColor = Program.foregroundColor;
            Console.BackgroundColor = Program.backgroundColor;

        }
        public static void throwTooLittleArgumentError(string[] command, string argumentMissing)
        {
            string commandS = StringTools.StringResasembler(command, 0);
            Log.Message($" Command {commandS} failed. Due to argument {argumentMissing} missing.  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"Command {commandS} failed, Due to the lack of Argument {argumentMissing} - Please Check the syntax, for more informations enter \"help\"");
            Console.WriteLine($"As of now, not all Legacy version 1 Commands are implementet. ");
            Console.ForegroundColor = Program.foregroundColor;
            Console.BackgroundColor = Program.backgroundColor;
        }
        public static void throwUnautohrizedAccess(string path)
        {
            Log.Message($"Unauthorized Access at {path} ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"We can't access this File, we don't have the permission to do that.");
            Console.ForegroundColor = Program.foregroundColor;
            Console.BackgroundColor = Program.backgroundColor;
        }
        public static void throwCustomError(string message)
        {
            Log.Message(message);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
            Console.ForegroundColor = Program.foregroundColor;
            Console.BackgroundColor = Program.backgroundColor;

        }
        public static void throwSkriptExecutionForbiden(string command)
        {

            Log.Message($"Unable to execute command {command}, this is a forbiden command for skripts.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"Command {command} can't be executed in a skript, because this could give some issues on your PC. (Sorry for the inconvinience, if you want to still be able to execute this command enter in first line <unsecure>)");
            Console.ForegroundColor = Program.foregroundColor;
            Console.BackgroundColor = Program.backgroundColor;
        }
        public static void throwVariableNotFound(string variableName) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"Variable {variableName} not found. This variable might be deleted or not created. Create variable with var {variableName} [content]");
            Console.ForegroundColor = Program.foregroundColor;
            Console.BackgroundColor = Program.backgroundColor;
        }

    }
}
