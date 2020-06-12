using System;
using System.Web.Mvc;
using Moq;
using TddApp;
using TddApp.Repository.Pattern;
using TddApp.Repository.Pattern.RepositoryModels;
using Xunit;

namespace TddAppTests.RepositoryPattern
{
    public class Class1_RepositoryTests
    {
        [Fact]
        public void TestClass1_DoStuffMethod()
        {
            string expectedSecretValue = "A";
            string expectedOtherSecretValue = "B";
            var mockServer = new Mock<IServer>();
            var mockRequest = new Mock<IRequest>();
            var mockSession = new Mock<ISession>();

            mockSession.SetupGet(_ => _["MySecretValue"]).Returns(expectedSecretValue);
            mockSession.SetupGet(_ => _["MyOtherSecretValue"]).Returns(expectedOtherSecretValue);
            mockSession.SetupSet(_ => _[It.IsAny<string>()]=It.IsAny<string>());
            mockRequest.Setup(_ => _.Session).Returns(mockSession.Object);
            mockServer.Setup(_ => _.Request).Returns(mockRequest.Object);

            var myClass = new Class1_Repository(mockServer.Object);

            bool result = myClass.DoStuff();

            Assert.True(result);
        }
    }
}
