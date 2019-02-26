using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Triangle: Shape
    {
        private readonly int _triangleBase;
        private readonly int _height;

        public Triangle(int triangleBase,int height):base("triangle")
        {
            this._height = height;
            this._triangleBase = triangleBase;
        }

        public override void GetArea()
        {
            Console.WriteLine($"The {base._name} area is: {this._triangleBase*this._height/2}");
        }
    }
}
