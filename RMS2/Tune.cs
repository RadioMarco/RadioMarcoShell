using System.Runtime.Versioning;

namespace RMS2
{
    [SupportedOSPlatform("windows")]
    internal class Tune
    {
        public static void Play(string tone = "277", string duration = "400", string octave = "1")
        {

            switch (tone)
            {

                case "1":
                    {
                        tone = "262";
                        break;
                    }
                case "2":
                    {
                        tone = "277";
                        break;
                    }
                case "3":
                    {
                        tone = "294";
                        break;
                    }
                case "4":
                    {
                        tone = "311";
                        break;
                    }
                case "5":
                    {
                        tone = "330";
                        break;
                    }
                case "6":
                    {
                        tone = "349";
                        break;
                    }
                case "7":
                    {
                        tone = "370";
                        break;
                    }
                case "8":
                    {
                        tone = "392";
                        break;

                    }
                case "9":
                    {
                        tone = "415";
                        break;
                    }
                case "10":
                    {
                        tone = "440";
                        break;
                    }
                case "11":
                    {
                        tone = "466";
                        break;
                    }
                case "12":
                    {
                        tone = "493";
                        break;
                    }
                default:
                    {
                        tone = "277";
                        break;
                    }

            }
            switch (duration)
            {
                case "1":
                    {
                        duration = "1600";
                        break;
                    }
                case "2":
                    {
                        duration = $"{1600 / 2}";
                        break;
                    }
                case "4":
                    {
                        duration = $"{1600 / 4}";
                        break;
                    }
                case "8":
                    {
                        duration = $"{1600 / 8}";
                        break;
                    }
                case "16":
                    {
                        duration = $"{1600 / 16}";
                        break;
                    }
                default:
                    {
                        duration = $"{1600 / 4}";
                        break;
                    }
            }
            double oktave = StringTools.StringToDouble(octave);
            double ton = StringTools.StringToDouble(tone);
            int length = StringTools.StringToInt(duration);
            ton = ton * oktave;
            Console.Beep((int)ton, length);



        }
    }





}
