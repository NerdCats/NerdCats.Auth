using System.Threading.Tasks;

namespace IdentityServer.Core.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
