namespace TrainingSessions.GoodCode
{
    // - A comment it's an apology
    // - Comments lie
    public class CommentsExample
    {
        // To calculate the future value, we multiply the present value
        // by 1 plus the percentage growth rate to the power of number of years.
        public double GetFV(decimal a, decimal b, int c)
        {
            return a * (1+(b/100))^c;
        }

        public double GetFutureValue(decimal presentValue, decimal growthRate, int years)
        {
            decimal growthRatePercentage = growthRate/100;

            return presentValue * (1+growthRatePercentage)^years;
        }

        private int[] GetValues()
        {
            // This method returns the values 1-3
            return new int[] {0 , 1, 2 , 3};
        }
    }
}