using ConsoleApp1.Sevice.Implementation;

public class Program
{
    static void Main(string[] args)
    {
        EmailService emailService = new EmailService();

        LoggingEmailService loggingEmailService = new LoggingEmailService(emailService);

        UserService userService = new UserService(loggingEmailService);

        userService.RegisterUser("usuario", 18, "usuario@gmail.com");
    }
}