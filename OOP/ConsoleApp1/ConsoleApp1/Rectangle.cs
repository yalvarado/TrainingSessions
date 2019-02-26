using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Rectangle : Shape
    {
        private readonly int _rectangleBase;
        private readonly int _height;

        public Rectangle(int rectangleBase,int height):base("rectangle")
        {
            this._height = height;
            this._rectangleBase = rectangleBase;
        }

        public override void GetArea()
        {
            Console.WriteLine($"The {base._name} area is: {this._rectangleBase * this._height}");
        }
    }
}
