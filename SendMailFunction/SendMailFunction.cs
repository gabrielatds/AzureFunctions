using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using SendMailFunction.Handlers.Interfaces;
using System;
using System.Threading.Tasks;

namespace SendMailFunction
{
    public class SendMailFunction
    {
        private readonly ISendMailFunctionHandler _sendMailFunctionHandler;

        public SendMailFunction(ISendMailFunctionHandler sendMailFunctionHandler)
        {
            _sendMailFunctionHandler = sendMailFunctionHandler;
        }

        [FunctionName("SendMailFunction")]
        public async Task Run([TimerTrigger("0 30 7 1/1 * ? *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"Initializing send mail function: {DateTime.Now}");
            await _sendMailFunctionHandler.Execute();
            log.LogInformation($"Finishing send mail function: {DateTime.Now}");
        }
    }
}
