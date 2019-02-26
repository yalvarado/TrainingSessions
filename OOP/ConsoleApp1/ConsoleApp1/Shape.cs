using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Shape
    {
        protected readonly string _name;

        public Shape(string name)
        {
            this._name = name;
        }

        public void GetShapeName()
        {
            Console.WriteLine($"this is a {this._name}");
        }

        public abstract void GetArea();

    }
}
