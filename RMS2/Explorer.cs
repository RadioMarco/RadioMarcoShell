namespace RMS2
{
    internal class Explorer
    {
        public static void ListAll(string directory)
        {
            Console.WriteLine();
            string[] file = Directory.GetFiles(directory);
            string[] dirs = Directory.GetDirectories(directory);
            Console.WriteLine("Subdirectories:");
            if (dirs.Length < 1)
                Console.WriteLine("No Subdirectories");
            for (int i = 0; i < dirs.Length; i++)
            {
                string[] longPath = dirs[i].Split('\\');
                dirs[i] = longPath[longPath.Length - 1];
                if (i % 2 == 0 || i == 0)
                {
                    if (Program.foregroundColor != ConsoleColor.Gray)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.ForegroundColor = Program.foregroundColor;
                }
                Console.Write($"{dirs[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Files:");
            if (file.Length < 1)
                Console.WriteLine("No Files");
            for (int i = 0; i < file.Length; i++)
            {
                string[] longPath = file[i].Split('\\');
                file[i] = longPath[longPath.Length - 1];
                if (i % 2 == 0|| i == 0)
                {
                    if (Program.foregroundColor != ConsoleColor.Gray)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.ForegroundColor = Program.foregroundColor;
                }
                Console.Write($"{file[i]} ");
            }
            Console.ForegroundColor = Program.foregroundColor;
            Console.WriteLine();
            Console.WriteLine();
        }
        
    }
}
