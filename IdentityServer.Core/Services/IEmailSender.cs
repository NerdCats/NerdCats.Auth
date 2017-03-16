using System.Threading.Tasks;

namespace IdentityServerCore.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
