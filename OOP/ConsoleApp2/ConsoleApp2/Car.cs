using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Car : IMove
    {
        public void Move()
        {
            Console.WriteLine("The car is speeding up");
        }
    }
}
