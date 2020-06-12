namespace TrainingSessions.GoodCode
{
    // decorator, strategy, or state
    public class ConditionalComplexity
    {

        protected Dictionary<string,ICalculate> _calculations = new Dictionary<string, ICalculate>
        {
            {"Calculation1", new Calculation1()},
            {"Calculation2", new Calculation2()},
            {"Calculation3", new Calculation3()}
        };

        public double CalculateComplexityV1(string calculationType, int number)
        {
            double result;

            switch(calculationType)
            {
                case "Calculation1":
                    if(number > 0)
                        result = this.Calculate1();
                    else
                        result = this.Calculate2();

                    break;
                case "Calculation2":
                    if(number==0)
                        result = this.Calculate1();
                    
                    result = this.Calculate2();
                    break;
                case "Calculation3":
                    if(number >= 0)
                        result = this.Calculate();

                    result = this.Calculate3();
                    break;
                default:
                    return 0d;
                    break;

            }
        }
        public double CalculateComplexityV2(string calculationType, int number)
        {
            if(this._calculations.ContainsKey(calculationType))
                return this._calculations[calculationType];

            return 0d;
        }






        private double Calculate1()
        {
            return 1d;
        }

        private double Calculate2()
        {
            return 1d;
        }

        private double Calculate3()
        {
            return 1d;
        }
    }

    public interface ICalculate
    {
        double Calculate(int number);
    }

    public class Calculation1 : ICalculate
    {
        public double Calculate(int number)
        {
            if(number==0)
                result = this.Calculation1();
            
            result = this.Calculation2();

            return result;
        }

         private double Calculation1()
        {
            return 1d;
        }

        private double Calculation2()
        {
            return 1d;
        }

    }

    public class Calculation2 : ICalculate
    {
        public double Calculate(int number)
        {
            if(number > 0)
                result = this.Calculation1();
            else
                result = this.Calculation2();

            return result;
        }

         private double Calculation1()
        {
            return 1d;
        }

        private double Calculation2()
        {
            return 1d;
        }

    }

        public class Calculation3 : ICalculate
    {
        public double Calculate(int number)
        {
            if(number >= 0)
                result = this.Calculation1();

            result = this.Calculation3();

            return result;
        }

         private double Calculation1()
        {
            return 1d;
        }

        private double Calculation3()
        {
            return 1d;
        }

    }

}