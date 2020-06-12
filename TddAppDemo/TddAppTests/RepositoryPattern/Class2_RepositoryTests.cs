using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using TddApp;
using TddApp.Repository.Pattern;
using TddApp.Repository.Pattern.RepositoryModels;
using Xunit;

namespace TddAppTests.RepositoryPattern
{
    public class Class2_RepositoryTests
    {
        [Fact]
        public void TestClass2_DoStuffMethod()
        {
            string expectedSecretValue = "A";
            string expectedOtherSecretValue = "B";

            var mockRepository = new Mock<IRepository>();
            mockRepository.Setup(_ => _.SetSessionValue(It.IsAny<string>(), It.IsAny<string>()));
            mockRepository.Setup(_ => _.GetSessionValue("MySecretValue")).Returns(expectedSecretValue);
            mockRepository.Setup(_ => _.GetSessionValue("MyOtherSecretValue")).Returns(expectedOtherSecretValue);

            var myClass = new Class2_Repository(mockRepository.Object);

            bool result = myClass.DoStuff();

            Assert.True(result);

        }
    }
}
