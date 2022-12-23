using Microsoft.Extensions.Logging;
using SendMailFunction.Handlers.Interfaces;
using SendMailFunction.Services.Interfaces;
using System.Threading.Tasks;

namespace SendMailFunction.Handlers
{
    public class SendMailFunctionHandler : ISendMailFunctionHandler
    {
        private readonly IEmailServiceTarget _adapter;

        public SendMailFunctionHandler(IEmailServiceTarget adapter)
        {
            _adapter = adapter;
        }
        public async Task Execute()
        {
            await _adapter.SendMail();
        }
    }
}
