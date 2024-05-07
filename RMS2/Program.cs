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
            initializeEV();
            Console.ForegroundColor = foregroundColor; //Schriftfarbe der Console
            
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
        }
        /// <summary>
        /// Initizializes the Environment Variables RMS2 needs.
        /// </summary>
        static void initializeEV()
        {
            string installationPath = Environment.GetEnvironmentVariable("RMS2");
            if ( installationPath == null)
            {
                Environment.SetEnvironmentVariable("RMS2",Environment.ProcessPath);
            }
            
            string logPath = Environment.GetEnvironmentVariable("RMS2logs");
            if (logPath == null)
            {
                logPath = Environment.GetEnvironmentVariable("Appdata");
                logPath += "\\.RMS2";
                Explorer.MakeDirectory(logPath);    
                Console.WriteLine(logPath); 
               
                Environment.SetEnvironmentVariable("RMS2logs", logPath);
            }

        }


    }








}