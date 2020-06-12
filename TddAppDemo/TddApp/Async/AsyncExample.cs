using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TddApp.Async
{
    
    public class AsyncExample
    {
        private readonly ILog _logger;

        public AsyncExample(ILog logger)
        {
            this._logger = logger;
        }
        public async Task<string> GetSTringAsync(int value)
        {
            return await Task.Run(() => $"Magic Number is: {value}");
           
        }

        public async Task DoStuffAsync()
        {
            await Task.Run(() =>
            {
                // Do nothing
            });
        }

        public async Task ThrowExceptionAsync()
        {
            await Task.Run(() => throw new InvalidOperationException());

        }


        public void OnMyEventWithNoError(object sender, EventArgs a)
        {
            this.DoStuffAsync().ContinueWith(this.OnMyAsyncMethodFailed, TaskContinuationOptions.OnlyOnFaulted);
        }

        public void OnMyEventWithError(object sender, EventArgs e)
        {
            this.ThrowExceptionAsync().ContinueWith(this.OnMyAsyncMethodFailed, TaskContinuationOptions.OnlyOnFaulted);
        }

        private void OnMyAsyncMethodFailed(Task task)
        {
            Exception ex = task.Exception;
            this._logger.Error(ex.Message);
            
        }

    }


}
