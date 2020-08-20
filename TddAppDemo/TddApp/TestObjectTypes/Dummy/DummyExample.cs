using System;

namespace TddApp.TestObjectTypes.Dummy
{
    public interface IDummyData
    {
        void DoStuff();
    }

    /// <summary>
    /// Dummy objects are passed around but never actually used. Usually they are just used to
    /// fill parameter lists.
    /// </summary>
    public class DummyDataExample : IDummyData
    {
        public void DoStuff()
        {
            throw new Exception("This should never be called");
        }
    }
}
