using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Fish: Animal,IMove
    {
        public override void Eat()
        {
            Console.WriteLine("The fish eats some plankton");
        }

        public void Move()
        {
            Console.WriteLine("The fish is swimming");
        }
    }
}
