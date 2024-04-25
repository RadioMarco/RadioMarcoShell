using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS2.timecalcres
{
    internal class Time
    {
        public static string timeInterpreter(string[] command)
        {
            if (command.Length < 2)
            {
                Error.throwTooLittleArgumentError(command, "none");
                return "-1 failed";
            }
            switch (command[1])
            {
                case "query":
                    Console.WriteLine(DateTime.Now);
                    break;
                case "todecimal":
                    if (command.Length > 2)
                    {
                        Console.WriteLine(TimeTools.RegularToDecimalTime(StringTools.StringToDouble(command[2])));
                        break;
                    }
                    else
                    {
                        Error.throwTooLittleArgumentError(command, "initialtime");
                        return "-1 failed";
                    }
                case "tonormal":
                    if (command.Length > 2)
                    {
                        Console.WriteLine(TimeTools.DecimalToRegularTime(StringTools.StringToDouble(command[2])));
                        break;
                    }
                    else
                    {
                        Error.throwTooLittleArgumentError(command, "initialtime");
                        return "-1 failed";
                    }
                case "workend":
                    {
                        if (command.Length < 5)
                        {
                            Error.throwTooLittleArgumentError(command, "startTime, breakStart,endTime");
                            return "-1 failed";
                        }
                        else if (command.Length > 5)
                        {
                            Console.WriteLine(TimeTools.Clean(TimeTools.EndTime(StringTools.StringToDouble(command[2]), StringTools.StringToDouble(command[3]), StringTools.StringToDouble(command[4]), StringTools.StringToDouble(command[5]))));
                        }
                        else
                        {
                            Console.WriteLine(TimeTools.Clean(TimeTools.EndTime(StringTools.StringToDouble(command[2]), StringTools.StringToDouble(command[3]), StringTools.StringToDouble(command[4]))));
                        }
                        break;
                    }
                case "difference":
                    if (command.Length < 4)
                    {
                        Error.throwTooLittleArgumentError(command, "time one, time two");
                        return "-1 failed";
                    }
                    else
                    {
                        Console.WriteLine(TimeTools.DecimalToRegularTime(TimeTools.CalcTimeDifference(TimeTools.RegularToDecimalTime(StringTools.StringToDouble(command[2])), TimeTools.RegularToDecimalTime(StringTools.StringToDouble(command[3])))));
                       
                    }
                    break;



                default:
                    RMS2.Error.throwArgumentError("time", command[1]);
                    return "-1 failed";
            }
            return "0 success";
        }
    }
}
