namespace TrainingSessions.GoodCode
{
    
    // Negative logic is harder to understand
    //
    // - Don’t ever not avoid negative logic
    public class NegativeLogicExamples
    {
        // Example 1
        public bool IsTeslaCar1(bool isCar, bool isElectric)
        {
            return !(!isCar || !isElectric);
        }

        public bool IsTeslaCar2(bool isCar, bool isElectric)
        {
            return isCar && isElectric;
        }

        // Example 2
        public bool IsValidNumber(int number)
        {
            if(!IsPrime(number) && number > 10)
                return true;
        }

        public bool IsValidNumber2(int number)
        {
            if(IsNotPrime(number) && number > 0)
                return true;
        }


        // Helper methods
        private bool IsPrime(int number)
        {
            return true;
        }
        private bool IsNotPrime(int number)
        {
            return true;
        }

    }

}