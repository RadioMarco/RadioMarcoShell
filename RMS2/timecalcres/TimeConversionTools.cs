using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS2.timecalcres
{
    internal class TimeConversionTools
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
            return initialTime + timeToAdd;
        }
        public static double EndTime(double startTime, double breakStart,double breakEnd, double pensum = 8.1)
        {
            double morningSpent = CalcTimeDifference(RegularToDecimalTime(startTime), RegularToDecimalTime(breakStart));
            double remainingTime = CalcTimeDifference(morningSpent, pensum);
            return AddTimeTo(breakEnd, remainingTime);

        }
    }
}
