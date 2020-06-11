namespace TrainingSessions.GoodCode
{
    // - Readability
    // - Having to change it in multiple places.
    public class MagicNumbersExample
    {
        private static readonly int WeeksInAYear = 52;
        private static readonly int DaysInAWeek = 7;
        private static readonly int WorkingHoursInADay = 8;
        private enum IntegerType
        {
            Positive = 1,
            Negative = -1
        }

        private int GetIntegerType(int number)
        {
            if(number >=0)
                return 1;

            return -1;
        }

        private IntegerType GetIntegerTypeV2(int number)
        {
            if(number >= 0)
                return IntegerType.Positive;


            return IntegerType.Negative;
        }


        private double CalculateHourlySalary(double anualSalary)
        {
            return anualSalary/2912;
        }
        
        private double CalculateHourlySalaryV2(double anualSalary)
        {
            return anualSalary/(52*7*8);
        }
        private double CalculateHourlySalaryV3(double anualSalary)
        {
            return anualSalary/(WeeksInAYear * DaysInAWeek * WorkingHoursInADay);
        }
    }
}