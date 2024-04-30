
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
                    return $"{DateTime.Now}";

                case "todecimal":
                    if (command.Length > 2)
                    {
                        return $"{TimeTools.RegularToDecimalTime(StringTools.StringToDouble(command[2]))}";

                    }
                    else
                    {
                        Error.throwTooLittleArgumentError(command, "initialtime");
                        return "-1 failed";
                    }
                case "tonormal":
                    if (command.Length > 2)
                    {
                        return $"{TimeTools.DecimalToRegularTime(StringTools.StringToDouble(command[2]))}";
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
                            return $"{TimeTools.Clean(TimeTools.EndTime(StringTools.StringToDouble(command[2]), StringTools.StringToDouble(command[3]), StringTools.StringToDouble(command[4]), StringTools.StringToDouble(command[5])))}";
                        }
                        else
                        {
                            return $"{TimeTools.Clean(TimeTools.EndTime(StringTools.StringToDouble(command[2]), StringTools.StringToDouble(command[3]), StringTools.StringToDouble(command[4])))}";
                        }
                    }
                case "difference":
                    if (command.Length < 4)
                    {
                        Error.throwTooLittleArgumentError(command, "time one, time two");
                        return "-1 failed";
                    }
                    else
                    {
                        return $"{TimeTools.DecimalToRegularTime(TimeTools.CalcTimeDifference(TimeTools.RegularToDecimalTime(StringTools.StringToDouble(command[2])), TimeTools.RegularToDecimalTime(StringTools.StringToDouble(command[3]))))}";
                    }

                default:
                    RMS2.Error.throwArgumentError("time", command[1]);
                    return "-1 failed";
            }

        }
    }
}
