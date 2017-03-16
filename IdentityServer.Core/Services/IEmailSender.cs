using System.Threading.Tasks;

namespace IdentityServer.Core.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
