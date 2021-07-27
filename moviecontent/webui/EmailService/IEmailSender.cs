using System.Threading.Tasks;

namespace webui.EmailService
{
    public interface IEmailSender
    {
         Task sendEmailAsync (string email,string subject,string message);

    }
}