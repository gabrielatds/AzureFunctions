using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SendMailFunction;
using SendMailFunction.Adapters;
using SendMailFunction.Handlers;
using SendMailFunction.Handlers.Interfaces;
using SendMailFunction.Services.Interfaces;

[assembly: WebJobsStartup(typeof(Startup))]
namespace SendMailFunction
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<ISendMailFunctionHandler, SendMailFunctionHandler>();
            builder.Services.AddScoped<IEmailServiceTarget, EmailServiceAdapter>();
        }
    }
}
