using System;
using System.Collections.Generic;
using System.Text;

namespace Session_00
{
    public class BasicExampleClass
    {
        #region Constants & Members

        private const string ANIMAL_TYPE = "fish";
        private readonly string _name;
        private readonly string _colour;

        private int _xCoordinate;
        private int _yCoordinate;

        #endregion

        #region Properties

        public string AnimalType { get { return ANIMAL_TYPE; } }
        public string Name { get; private set; }
        public string Colour { get; private set; }
        public int XCoordinate { get; private set; }
        public int YCoordinate { get; private set; }

        #endregion

        #region Constructors

        public BasicExampleClass(string name, string colour)
        {
            this._name = name;
            this._colour = colour;
        }

        public BasicExampleClass():this("NoName","red")
        {}

        #endregion

        #region Public Methods

        public void MoveTo(int xCoordinate, int yCoordinate)
        {
            this.DisplayMessage("Moving from:");
            this.DisplayCoordinates();

            this._xCoordinate = xCoordinate;
            this._yCoordinate = yCoordinate;

            this.DisplayMessage("To:");
            this.DisplayCoordinates();
        }

        #endregion

        #region Private Methods (Helpers)

        private void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        private void DisplayCoordinates()
        {
            Console.WriteLine($"X: {this._xCoordinate}");
            Console.WriteLine($"Y: {this._yCoordinate}");
        }

        #endregion

    }
}
