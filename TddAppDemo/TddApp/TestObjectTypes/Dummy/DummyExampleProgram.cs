using System;

namespace TddApp.TestObjectTypes.Dummy
{
    public class DummyExampleProgram
    {
        private readonly IDummyExample _something;

        public DummyExampleProgram(IDummyExample something)
        {
            this._something = something;
        }

        // This method requires a not null DummyExample object or it'll fail
        public string DoSomeStuff(DummyDataExample exampleData)
        {
            if(exampleData==null)
                throw new Exception("Shouldn't be null");

            return this._something.GetSomething(exampleData);
            
        }
    }
}