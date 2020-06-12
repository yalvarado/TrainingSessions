using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using TddApp.TestObjectTypes;
using TddApp.TestObjectTypes.Spy;
using Xunit;

namespace TddAppTests.TestObjectTypes
{
    public class SpyExampleTests
    {
        [Fact]
        public void Test()
        {
            int expected = 2;

            var mockEmailServer = new Mock<IEmail>();
            mockEmailServer.Setup(_ =>
                _.SendEmail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()));

            var mySpy = new SpyExample(mockEmailServer.Object);

            var mySpyExampleProgram = new SpyExampleProgram(mySpy);
            mySpyExampleProgram.DoSomething();

            // services only send emails when an even number is passed on
            // serviceA and ServiceC pass even numbers whereas serviceB
            // passes an odd number, hence the expected result should be 2.
            Assert.True(mySpy.GetEmailCount()==expected,$"Expected: {expected}, Actual: {mySpy.GetEmailCount()}");
        }
    }
}
