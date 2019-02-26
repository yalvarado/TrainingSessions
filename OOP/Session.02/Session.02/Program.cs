using System;

namespace Session_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Lion("Charlie");
            Animal lionKing = new LionKing("Arthur");
            LionKing lionking2 = new LionKing("Arthur");

            lion.Move();
            lionKing.Move();
            lionking2.Move();

            Console.ReadLine();
        }
    }
}
