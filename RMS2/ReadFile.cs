using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
    internal class ReadFile
    {
        public static void read(string path)
        {
            try
            {


                string[] content = File.ReadAllLines(path);
                foreach (string text in content)
                {
                    Console.WriteLine(text);
                }
            }
            catch (FileNotFoundException)
            {
                Error.throwArgumentError("read", path);
            }

        }
    }
}
