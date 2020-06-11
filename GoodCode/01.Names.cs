namespace TrainingSessions.GoodCode
{
    // Naming variables
    // - don't be cheap, go long.
    // - variables (what they are), methods (what they do). 
    // - Use meaninful names and always follow convention.
    public class NamingExamples
    {
        public double GetFV(decimal a, decimal b, int c)
        {
            return a * (1+(b/100))^c;
        }

        public double GetFutureValue(decimal presentValue, decimal growthRate, int years)
        {
            decimal growthRatePercentage = growthRate/100;

            return presentValue * (1+growthRatePercentage)^years;
        }
    }
}