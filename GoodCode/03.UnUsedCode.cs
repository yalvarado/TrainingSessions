namespace TrainingSessions.GoodCode
{
    public class UnUsedCodeExample
    {

        // public double GetFutureValue(decimal a, decimal b, int c)
        // {
        //     return a * (1+(b/100))^c;
        // }

        
        public double GetFutureValue(decimal presentValue, decimal growthRate, int years)
        {
            decimal growthRatePercentage = growthRate/100;

            return presentValue * (1+growthRatePercentage)^years;
        }
    }
}