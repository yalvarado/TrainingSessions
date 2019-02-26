using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion myLion = new Lion();
            myLion.Name = "Johnny";
            Bird myBird = new Bird();
            Fish myFish=  new Fish();

            List<Animal> myAnimals = new List<Animal>()
            {
                myLion,myBird,myFish
            };

            foreach (var myAnimal in myAnimals)
            {
                myAnimal.Eat();
                
            }

            Car myCar = new Car();

            List<IMove> myMovingObjects = new List<IMove>()
            {
                myLion,myBird,myFish,myCar
            };

            foreach (var myMovingObject in myMovingObjects)
                myMovingObject.Move();

            


            if(myLion is Animal)
                Console.WriteLine("This is an animal");

            if(myCar is Animal)
                Console.WriteLine("This is an animal");


            Console.ReadKey();
        }
    }
}
