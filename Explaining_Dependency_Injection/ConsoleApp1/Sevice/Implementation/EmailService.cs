using ConsoleApp1.Sevice.Interface;

namespace ConsoleApp1.Sevice.Implementation
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {          
            Console.WriteLine($"Enviando email para {to}: {subject}");
        }
    }
}
