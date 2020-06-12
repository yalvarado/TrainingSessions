using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Moq;
using TddApp.Async;
using Xunit;

namespace TddAppTests.Async
{
    public class AsyncExampleTests
    {
        [Fact]
        public async Task Test_GetSTringAsync()
        {
            int magicNumber = 10;
            string expected = $"Magic Number is: {magicNumber}";
            var asyncExample = new AsyncExample(null);


            // ConfigureAwait(true) only if you require to continue on the original thread
            var result = await asyncExample.GetSTringAsync(magicNumber).ConfigureAwait(false);

            Assert.True(result==expected);
        }

        [Fact]
        public async Task Test_DoAsyncStuff()
        {
            var asyncExample = new AsyncExample(null);

            await asyncExample.DoStuffAsync().ConfigureAwait(false);

            Assert.True(true);
        }

        [Fact]
        public async Task Test_ThrowExceptionAsync()
        {
            var asyncExample = new AsyncExample(null);

            await Assert.ThrowsAsync<InvalidOperationException>(() => asyncExample.ThrowExceptionAsync());


        }

        [Fact]
        public void Test_OnEventHandlerWithNoError()
        {
            var mockErrorLogger = new Mock<ILog>();
            mockErrorLogger.Setup(_ => _.Error(It.IsAny<string>()));

            var asyncExample = new AsyncExample(mockErrorLogger.Object);
            asyncExample.OnMyEventWithNoError(null,null);

            mockErrorLogger.Verify(_=>_.Error(It.IsAny<string>()),Times.Never());
        }

        //[Fact]
        //public void Test_OnEventHandlerWithError()
        //{
        //    var mockErrorLogger = new Mock<ILog>();
        //    mockErrorLogger.Setup(_ => _.Error(It.IsAny<string>()));

        //    var asyncExample = new AsyncExample(mockErrorLogger.Object);

        //    asyncExample.OnMyEventWithError(null,null);



        //    mockErrorLogger.Verify(_=>_.Error(It.IsAny<string>()),Times.Once);
        //}
    }
}
