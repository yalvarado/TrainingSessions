using System;
using System.Reflection.Metadata;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {            
            Shape myRectangle = new Rectangle(2,3);
            myRectangle.GetShapeName();
            myRectangle.GetArea();

            Shape myTriangle = new Triangle(5,2);
            myTriangle.GetShapeName();
            myTriangle.GetArea();


            Console.ReadLine();

        }
    }
}
