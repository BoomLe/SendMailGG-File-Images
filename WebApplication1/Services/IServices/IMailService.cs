using WebApplication1.Models;

namespace WebApplication1.Services.IServices
{
    public interface IMailServices
    {
        Task SendEmailAsync(MailRequest mailRequest);
        Task SendWelcomeEmailAsync(WelcomeRequest request);
    }
}
