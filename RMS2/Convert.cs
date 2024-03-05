
namespace RMS2
{
    internal class Converter
    {
        public static double ConverterInterpreter(string baseUnit,string EndUnit,string baseUnitValue)
        {
            double result = 6.9;
            switch (baseUnit)
            {
                

                case "ft":
                    {
                        if (EndUnit == "cm")
                           result = FootToCentiMeter(StringTransformationTools.StringToDouble(baseUnitValue));
                        if (EndUnit == "inch")
                            result = FootToInch(StringTransformationTools.StringToDouble(baseUnitValue));
                        if (EndUnit == "yard")
                            result = FootToYard(StringTransformationTools.StringToDouble(baseUnitValue));
                        break;
                    }
                case "cm":
                    {
                        if (EndUnit == "ft")
                            CentiMeterToFoot(StringTransformationTools.StringToDouble(baseUnitValue));
                        if (EndUnit == "inch")
                            CentiMeterToInch(StringTransformationTools.StringToDouble(baseUnitValue));
                        if (EndUnit == "yard")
                            CentiMeterToYard(StringTransformationTools.StringToDouble(baseUnitValue));
                        break;
                    }
            }
            
            return result ;
        }
        //Foot
        public static double FootToCentiMeter(double Foot)
        {
            return Foot * 30.48;
        }
        public static double FootToInch(double Foot)
        {
            return Foot * 12;
        }
        public static double FootToYard(double Foot)
        {
            return Foot / 3;
        }
        //CentiMeter
        public static double CentiMeterToFoot(double CentiMeter)
        {
            return CentiMeter / 30.48;
        }
        public static double CentiMeterToInch(double CentiMeter)
        {
            return CentiMeter / 2.54;
        }
        public static double CentiMeterToYard(double CentiMeter)
        {
            return CentiMeter / 91.44;
        }

    }
}
