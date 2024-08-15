using ConsoleApp1.Sevice.Interface;

namespace ConsoleApp1.Sevice.Implementation;

public class LoggingEmailService : IEmailService
{
    private readonly IEmailService _innerEmailService;

    public LoggingEmailService(IEmailService innerEmailService)
    {
        _innerEmailService = innerEmailService;
    }

    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine("Log: Enviando email...");
        _innerEmailService.SendEmail(to, subject, body);
    }
}