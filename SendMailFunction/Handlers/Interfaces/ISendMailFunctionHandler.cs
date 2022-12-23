using System.Threading.Tasks;

namespace SendMailFunction.Handlers.Interfaces
{
    public interface ISendMailFunctionHandler
    {
        Task Execute();
    }
}
