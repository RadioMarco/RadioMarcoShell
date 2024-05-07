namespace RMS2.timecalcres
{
    internal class TimeTools
    {
        public static double RegularToDecimalTime(double initialTime)
        {
            double hours = Math.Floor(initialTime);
            double minutes = (initialTime - hours) * 100;
            double convertedTime = Math.Round(hours + (minutes / 60),2);
            return convertedTime;
        }
        public static double DecimalToRegularTime(double initialTime)
        {
            double minutes = ((initialTime * 60) % 60)/100;
            double hours = Math.Floor(initialTime);
            if (minutes < 0.59)
            {
                hours++;
                    minutes -= 0.6;
            }
            
            double convertedTime =Math.Round( hours + minutes,2);
            return convertedTime;
        }
        public static double CalcTimeDifference(double startTime, double endTime)
        {
            return endTime - startTime;
        }
        public static double AddTimeTo(double initialTime, double timeToAdd)
        {
           
           double result = Math.Round(initialTime,2) + Math.Round(timeToAdd,2);
            int hours = (int)result;
            double minutes = result - hours;
            if (minutes > 0.59)
            {
                hours++;
                minutes = Math.Round(minutes,2) - 0.6;
                result = hours + minutes;
            }

            return result;
        }
        public static double EndTime(double startTime, double breakStart,double breakEnd, double pensum = 8.1)
        {
            double morningSpent = CalcTimeDifference(RegularToDecimalTime(startTime), RegularToDecimalTime(breakStart));
            double remainingTime = CalcTimeDifference(morningSpent, pensum);
            return AddTimeTo(breakEnd, remainingTime);

        }
        public static string Clean(double time)
        {
            
            string StringifiedTime = $"{time}" ;
            if (StringifiedTime.Length == 1)
            {
                StringifiedTime = time + ".00";
            }
            else if (StringifiedTime.Length == 2)
            {
                StringifiedTime = time + ".00";
            }
            else if (StringifiedTime.Length == 3)
            {
                StringifiedTime = time + "0";
            }
            else if (StringifiedTime.Length == 4)
            {
                StringifiedTime = time + "0";
            }
            else
            {
                StringifiedTime = $"{time}";
            }


            return StringifiedTime;
        }
    }
}
