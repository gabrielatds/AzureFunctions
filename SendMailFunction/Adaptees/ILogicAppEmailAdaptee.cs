using Refit;
using SendMailFunction.Dtos;
using System.Threading.Tasks;

namespace SendMailFunction.Adaptees
{
    public interface ILogicAppEmailAdaptee
    {
        [Post("")]
        Task SendEmailAsync([Body]Email email);
    }
}
