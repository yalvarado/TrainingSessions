using System;
using System.Collections.Generic;
using System.Text;

namespace Session_02
{
    public class LionKing : Animal
    {
        public LionKing(string name): base(name,nameof(LionKing))
        { }

        // hidding
        public new void Move()
        {
            Console.WriteLine($"{base._name} the {base._animalType} is moving (from the LIONKING class)");
        }
    }
}
