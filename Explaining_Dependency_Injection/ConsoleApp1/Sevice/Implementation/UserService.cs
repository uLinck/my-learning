using ConsoleApp1.Model;
using ConsoleApp1.Sevice.Interface;

namespace ConsoleApp1.Sevice.Implementation
{
    public class UserService
    {
        private readonly IEmailService _emailService;

        public UserService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public User RegisterUser(string username, int idade, string email)
        {
            var user = new User(username, idade);

            _emailService.SendEmail(email, "Bem-vindo", "Obrigado por se registrar!");

            return user;
        }
    }
}
