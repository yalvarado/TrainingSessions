using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using TddApp.TestObjectTypes;
using TddApp.TestObjectTypes.Mock;
using Xunit;

namespace TddAppTests.TestObjectTypes
{
    public class MockExampleTests
    {
        [Fact]
        public void Test()
        {
            string expected = "success";
            var mockInterface = new Mock<IMockExample>();
            mockInterface.Setup(_ => _.GetValue()).Returns(expected);

            var myMockExample = new MockExample(mockInterface.Object);
            var result = myMockExample.DoStuff();

            Assert.Equal(result,expected);

        }
    }
}
