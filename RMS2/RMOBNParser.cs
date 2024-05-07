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
