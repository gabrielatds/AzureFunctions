using System.Threading.Tasks;

namespace SendMailFunction.Services.Interfaces
{
    public interface IEmailServiceTarget
    {
        Task SendMailAsync();
    }
}
