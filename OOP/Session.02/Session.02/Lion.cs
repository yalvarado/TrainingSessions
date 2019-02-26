using System;
using System.Collections.Generic;
using System.Text;

namespace Session_02
{
    public class Lion : Animal
    {
        
        public Lion(string name): base(name,nameof(Lion))
        {}

        public override void Move()
        {
            base.Move();

            Console.WriteLine($"{base._name} the {base._animalType} is moving (from the LION class)");
        }

    }
}
