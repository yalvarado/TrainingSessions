using TddApp.TestObjectTypes.Stub;
using Xunit;

namespace TddAppTests.TestObjectTypes
{
    public class StubExampleTests
    {
        [Fact]
        public void Test()
        {
            string expected = "Success";

            var myStubExampleProgram = new StubExampleProgram(new StubExample());
            var result = myStubExampleProgram.DoStuff();

            Assert.Equal(result,expected);

        }
    }
}
