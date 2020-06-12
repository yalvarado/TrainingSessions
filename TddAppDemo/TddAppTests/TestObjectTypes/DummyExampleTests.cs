using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using TddApp.TestObjectTypes;
using TddApp.TestObjectTypes.Dummy;
using Xunit;

namespace TddAppTests.TestObjectTypes
{
    public class DummyExampleTests
    {

        [Fact]
        public void TestTheDummyExample()
        {
            var mockSomething = new Mock<IDummyExample>();
            mockSomething.Setup(_ => _.GetSomething(It.IsAny<DummyDataExample>())).Returns(string.Empty);

            var myProgram = new DummyExampleProgram(mockSomething.Object);
            var result = myProgram.DoSomeStuff(new DummyDataExample());

            Assert.True(result==string.Empty);

        }
    }
}
