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

                case "c":
                case "1":
                    {
                        tone = "262";
                        break;
                    }
                case "c#":
                case "csharp":
                case "2":
                    {
                        tone = "277";
                        break;
                    }
                case "d":
                case "3":
                    {
                        tone = "294";
                        break;
                    }
                case "d#":
                case "dsharp":
                case "4":
                    {
                        tone = "311";
                        break;
                    }
                case "e":
                case "5":
                    {
                        tone = "330";
                        break;
                    }
                case "f":
                case "6":
                    {
                        tone = "349";
                        break;
                    }
                case "f#":
                case "fsharp":
                case "7":
                    {
                        tone = "370";
                        break;
                    }
                case "g":
                case "8":
                    {
                        tone = "392";
                        break;

                    }
                case "g#":
                case "gsharp":
                case "9":
                    {
                        tone = "415";
                        break;
                    }
                case "a":
                case "10":
                    {
                        tone = "440";
                        break;
                    }
                case "a#":
                case "asharp":
                case "11":
                    {
                        tone = "466";
                        break;
                    }
                case "b":
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
                //whole
                case "1":
                    {
                        duration = "1600";
                        break;
                    }
                //half
                case "2":
                    {
                        duration = $"{1600 / 2}";
                        break;
                    }
                //quarter
                case "4":
                    {
                        duration = $"{1600 / 4}";
                        break;
                    }
                //eighth
                case "8":
                    {
                        duration = $"{1600 / 8}";
                        break;
                    }
                //sixteenth
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
