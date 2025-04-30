static class CalculStaticConvertor

{
     private static double dollarRate;
    private static double euroRate;
 private static double GetDollarRate()
        {
            return 42; // call database
        }

        private static double GetEuroRate()
        {
            return 45; // call database
        }
public static double ConvertEuroToHrn(double sum)
        {
            return euroRate * sum;
        }

        public static double ConvertDollarsToHrn(double sum)
        {
            return dollarRate * sum;
        }

        public static double ConvertHrnToEuro(double sum)
        {
            if (euroRate == 0)
                return 0;   

            return sum / euroRate;
        }

        public static double ConvertHrnToDollars(double sum)
        {
            if (dollarRate == 0)
                return 0;

            return sum / dollarRate;
        }

}