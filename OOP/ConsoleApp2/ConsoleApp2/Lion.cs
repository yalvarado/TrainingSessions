using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Lion: Animal,IMove
    {
        public string Name { get; set; }
        public override void Eat()
        {
            Console.WriteLine("The lion eats a zebra");
        }

        public void Move()
        {
            Console.WriteLine("The lion is running");
        }
    }
}
