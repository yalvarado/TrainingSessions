using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Bird: Animal,IMove
    {
        public override void Eat()
        {
            Console.WriteLine("The bird eats a worm");
        }

        public void Move()
        {
            Console.WriteLine("The bird is flying");
        }
    }
}
