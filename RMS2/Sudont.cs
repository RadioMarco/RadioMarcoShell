namespace RMS2
{
    internal class Sudont
    {
        public static void Say(int sudontLine = -1)
        {
            string[] sudontLines = {"Su, do it yourself", "Tux doesn't response", "Sir, this is a Wendy's", "Opensource is overrated, just kidding", "Shut up",
                                  "unlike me, Bash isn't thankful", "sudoesn't response","You're already admin", "We don't throw the roots here",
                                    "Carrot","You're now root","Beat root", "Beetroot", "ratio","L", "Don't call me like this"};
            if (sudontLine < 0 || sudontLine > sudontLines.Length-1)
            {
                Random random = new Random();
                sudontLine = random.Next(0, sudontLines.Length);

            }
            Console.WriteLine(sudontLines[sudontLine]);

        }

    }
}
