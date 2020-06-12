using System;

namespace TddApp.TestObjectTypes.Stub
{
    /// <summary>
    /// Stubs provide canned answers to calls made during the test, usually not responding
    /// at all to anything outside what's programmed in for the test.
    /// </summary>
    public class StubExample : IStubExample
    {
        public string GetData1()
        {
            return "Success";
        }

        public string GetData2()
        {
            throw new NotImplementedException();
        }
    }
}
