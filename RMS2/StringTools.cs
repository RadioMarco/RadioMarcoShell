
namespace RMS2
{
    internal class StringTools
    {
        public static string StringResasembler      (string[] array, int firstEntry = 1,char dividingSign = ' ')
        {
            string? reasembledString = Variables.GetDefaultVariables(array[firstEntry]);
            if (firstEntry != array.Length - 1)
            {
                for (int i = firstEntry + 1; i < array.Length; i++)
                {
                    array[i] = Variables.GetDefaultVariables(array[i]);
                    reasembledString = $"{reasembledString}{dividingSign}{array[i]}";
                }
            }
            return reasembledString;
        }
        public static int StringToInt(string valueToConvert,int defaultvalue = 0)
        {
            int convertedValue = 0;
            try
            {
                Variables.GetDefaultVariables(valueToConvert);
                convertedValue = Convert.ToInt32(valueToConvert);
            }
            catch (FormatException)
            {
                Error.throwArgumentError("StringTools.StringToInt", valueToConvert);
                Log.Message("Expected to be an Naturalnumber (BASE 10) with no decimal point (e.g. 7 not 6.9). ");
                convertedValue = defaultvalue;
            }
            return convertedValue;
        }
        public static double StringToDouble(string valueToConvert, int defaultvalue = 0)
        {
            double convertedValue = 0;
            try
            {
                Variables.GetDefaultVariables(valueToConvert);
                convertedValue = Convert.ToDouble(valueToConvert);
            }
            catch (FormatException)
            {
                Error.throwArgumentError("StringTools.StringToDouble", valueToConvert);
                Log.Message("Expected to be an Naturalnumber (BASE 10) with (or without) decimal point ");
                convertedValue = defaultvalue;
            }
            return convertedValue;
        }

    }
}
