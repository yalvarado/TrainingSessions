using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using TddApp.AdapterPattern;
using TddApp.AdapterPattern.AdapterModels;
using Xunit;

namespace TddAppTests.AdapterPattern
{
    public class Class2_AdapterTests
    {
        [Fact]
        public void TestStuff()
        {
            var mockFileWriter = new Mock<IFileWriterAdapter>();
            mockFileWriter.Setup(_ => _.Initialise(It.IsAny<string>()));
            mockFileWriter.Setup(_ => _.WriteLineAsync(It.IsAny<string>()));
            mockFileWriter.Setup(_ => _.Close());

            var myClass= new Class2_Adapter(mockFileWriter.Object);
            myClass.DoStuff();

            mockFileWriter.VerifyAll();
        }
    }
}
