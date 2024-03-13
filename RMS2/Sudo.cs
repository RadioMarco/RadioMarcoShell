using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
    internal class Sudo
    {
        public static void Say(int sudoLine = -1)
        {
            string[] sudoLines = {"Su, do it yourself", "Tux doesn't response", "Sir, this is a Wendy's", "Opensource is overrated, just kidding", "Shut up",
                                  "unlike me, Bash isn't thankful", "sudoesn't response","You're already admin", "We don't throw the roots here",
                                    "Carrot","You're now root","Beat root", "Beetroot", "ratio","L", "Don't call me like this"};
            if (sudoLine < 0 || sudoLine > sudoLines.Length-1)
            {
                Random random = new Random();
                sudoLine = random.Next(0, sudoLines.Length);

            }
            Console.WriteLine(sudoLines[sudoLine]);

        }

    }
}
