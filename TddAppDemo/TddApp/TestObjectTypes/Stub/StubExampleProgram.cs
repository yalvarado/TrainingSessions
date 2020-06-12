namespace TddApp.TestObjectTypes.Stub
{
    public class StubExampleProgram
    {
        private readonly IStubExample _stubExample;

        public StubExampleProgram(IStubExample stubExample)
        {
            this._stubExample = stubExample;
        }
        public string DoStuff()
        {
            return this._stubExample.GetData1();
        }
    }
}