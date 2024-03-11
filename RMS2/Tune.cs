using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
    internal class Tune
    {
        public static void Play(string tone = "277", string duration = "400", string octave = "1")
        {
            if (System.OperatingSystem.IsWindows())
            {

            
            switch(tone)
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
            switch(duration)
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
                        duration = $"{1600/4}";
                        break;
                    }
            }
                double oktave = StringTransformationTools.StringToDouble(octave);
            double ton = StringTransformationTools.StringToDouble(tone);
            int length = StringTransformationTools.StringToInt(duration);
                ton = ton * oktave;
            Console.Beep((int) ton,length);
            

           
            }
            else
            {
                Error.throwCustomError("Dein Betriebssystem ist NICHT Windows, dieser Befehl funktioniert  nur auf Windows. Entschuldigung, für die unannähmlichkeiten.");
            }
        }

    }

    
    
}
