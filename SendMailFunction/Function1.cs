using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;

namespace SendMailFunction
{
    public class SendMailHandler
    {
        [FunctionName("SendMailFunction")]
        public void Run([TimerTrigger("0 30 7 1/1 * ? *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"Initializing send mail function: {DateTime.Now}");
        }
    }
}
