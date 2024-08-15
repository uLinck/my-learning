using ConsoleApp1.Model;

namespace ConsoleApp1.Sevice.Interface
{
    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }
}
