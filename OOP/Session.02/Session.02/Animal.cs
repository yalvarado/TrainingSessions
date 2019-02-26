using System;
using System.Collections.Generic;
using System.Text;

namespace Session_02
{
    public abstract class Animal
    {
        protected readonly string _name;
        protected readonly string _animalType;


        public Animal(string name,string animalType)
        {            
            this._name = name;
            this._animalType = animalType;
        }

        public virtual void Move()
        {
            Console.WriteLine($"{this._name} the {this._animalType} is moving (from the BASE class)");
        }
        
    }
}
