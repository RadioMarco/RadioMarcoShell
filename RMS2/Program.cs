using System.Drawing;

namespace RMS2
{
    /// <summary>
    /// Haupt Klasse. Diese Klasse Leitet das Programm 
    /// </summary>
    internal class Program
    {
        public static string initialPath = Environment.CurrentDirectory;
        public static string commandPath = Environment.CurrentDirectory;
        public static ConsoleColor foregroundColor = ConsoleColor.White;
        public static ConsoleColor backgroundColor = ConsoleColor.Black;
        /// <summary>
        /// Die Main Methode. Sie ist das Wichtigste des ganzen Programms
        /// </summary>
        static void Main()
        {
            Console.ForegroundColor = foregroundColor;
            StartUp.Title();

            string? status;
            Log.Message("start");
            do
            {
                Console.Title = "RMS2";
                
                Console.Write($"{Environment.UserName}@{Environment.CurrentDirectory}> ");
                status = Console.ReadLine();
                Log.Command(status);
                string[] command = status.Split(' ');
                command[0] = command[0].ToLower();
                status = CommandInterpreter.interpret(CommandInterpreter.RepeaterChecker(command));
 
                   if (status == "-1 failed")
                {
                    Error.throwCommandError(command[0]);

                }
            } while (status != "-2 shutdown");

            Console.WriteLine("Console will shutdown");
            Thread.Sleep(1000);
            Log.Message("stop");



        }
       

        }







    
}