using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
    internal class RMOBNParser
    {
        public static string[] ObjectParser(string rowFromFile)
        {
            string[] parsedObject = rowFromFile.Split('€');
            return parsedObject;
        }
    }
}
