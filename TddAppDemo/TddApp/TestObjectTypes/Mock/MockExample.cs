

namespace TddApp.TestObjectTypes.Mock
{
    /// <summary>
    /// objects pre-programmed with expectations which form a specification of the calls they
    /// are expected to receive.
    /// </summary>
    public class MockExample
    {
        private readonly IMockExample _mockExample;

        public MockExample(IMockExample example)
        {
            this._mockExample = example;
        }

        public string DoStuff()
        {
            return this._mockExample.GetValue();
        }
    }
}
