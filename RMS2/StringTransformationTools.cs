using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
    internal class StringTransformationTools
    {
        public static string StringResasembler(string[] array, int firstEntry = 1,char dividingSign = ' ')
        {
            string? reasembledString = array[firstEntry];
            if (firstEntry != array.Length - 1)
            {
                for (int i = firstEntry + 1; i < array.Length; i++)
                {
                    reasembledString = $"{reasembledString}{dividingSign}{array[i]}";
                }
            }
            return reasembledString;
        }
        public static int StringToInt(string valueToConvert)
        {
            int convertedValue = 0;
            try
            {
                convertedValue = Convert.ToInt32(valueToConvert);
            }
            catch (FormatException)
            {
                Error.throwArgumentError("StringTransformationTools.StringToInt", valueToConvert);
                Log.Message("Expected to be an Naturalnumber (BASE 10) with no decimal point (e.g. 7 not 6.9). ");
                convertedValue = 0;
            }
            return convertedValue;
        }
        public static double StringToDouble(string valueToConvert)
        {
            double convertedValue = 0;
            try
            {
                convertedValue = Convert.ToDouble(valueToConvert);
            }
            catch (FormatException)
            {
                Error.throwArgumentError("???", valueToConvert);
                Log.Message("Expected to be an Naturalnumber (BASE 10) with (or without) decimal point ");
                convertedValue = 0;
            }
            return convertedValue;
        }

    }
}
