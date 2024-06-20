namespace Marcoshell.amatrix
{
    internal class Matrix101
    {
        public static void Matrix(int times = 1,bool debug = false)
        {
            Console.Title = "α-Matrix";
            Console.WriteLine("Scanning for devices...");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int[] numbersdist = { 0, 0, 0 };

            int bit;
            for (int i = times; i > 0; i--)
            {
                for (int j = Console.WindowHeight-1; j > 0; j--)
                {
                    for (int k = Console.WindowWidth; k > 0; k--)
                    {
                        Random rant = new Random();
                        bit = rant.Next(0, 3);
                        switch (bit)
                        {
                            case 0:
                                {
                                    Console.Write("0");
                                    numbersdist[0]++;
                                    break;
                                }
                            case 1:
                                {
                                    Console.Write("1");
                                    numbersdist[1]++;
                                    break;
                                    
                                }
                            default:
                                {
                                    Console.Write(" ");
                                    numbersdist[2]++;
                                    break;
                                }
                        }

                    }
                    Console.WriteLine("");
                    Thread.Sleep(15);

                }
                Console.SetCursorPosition(0, 0);
              

            }
            Console.SetCursorPosition(0, Console.WindowHeight-1);
            Console.ForegroundColor = RMS2.Program.foregroundColor;
            if (debug)
                Console.WriteLine($"0: {numbersdist[0]}, 1: {numbersdist[1]}, space: {numbersdist[2]}");
        }
    }
}