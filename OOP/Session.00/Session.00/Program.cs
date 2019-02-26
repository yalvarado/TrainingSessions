using System;
using System.Collections.Generic;
using Session_00;

namespace Session._00
{
    class Program
    {


        static void Main(string[] args)
        {

            RunStaticTest();
            //ReferenceVsValueTest();

            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }


        private static void RunStaticTest()
        {
            StaticTest myTest1 = new StaticTest();
            myTest1.NumericStaticProperty = 1;
            myTest1.NumericNormalProperty = 1;

            StaticTest myTest2 = new StaticTest();
            myTest2.NumericStaticProperty = 2;
            myTest2.NumericNormalProperty = 2;

            Console.WriteLine($"STATIC: Test1={myTest1.NumericStaticProperty}, Test2={myTest2.NumericStaticProperty}");
            Console.WriteLine($"NON-STATIC: Test1={myTest1.NumericNormalProperty}, Test2={myTest2.NumericNormalProperty}");
            Console.WriteLine();


            // Value vs Reference

        }

        private static void ReferenceVsValueTest()
        {
            ReferenceTest myTest1 = new ReferenceTest();

            myTest1.ExtraValue = 1;
            int value1 = 1;
            int value2 = 1;
            SetExtraValueTo3(myTest1, value1,ref value2);

            Console.WriteLine($"REFvsVAL: ExtraValue={myTest1.ExtraValue}, Value1={value1}, Value2={value2}");

        }
        private static void SetExtraValueTo3(ReferenceTest myObject, int value1, ref int value2)

        { 
            myObject.ExtraValue = 3;
            value1 = 3;
            value2 = 3;
        }
    }
}
