using System.Threading.Tasks;

namespace IdentityServerCore.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
