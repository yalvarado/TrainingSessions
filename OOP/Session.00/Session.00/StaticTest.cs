using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Session_00
{
    public class StaticTest
    {
        private static int _numericStaticProperty;
        private int _numericNormalProperty;

        public int NumericStaticProperty
        {
            get { return _numericStaticProperty; }
            set { _numericStaticProperty = value; }
        }

        public int NumericNormalProperty
        {
            get { return this._numericNormalProperty; }
            set { this._numericNormalProperty = value; }
        }

        public int ExtraValue { get; set; }

    }
}
