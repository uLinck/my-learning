namespace ConsoleApp1.Model
{
    public class Email
    {
        public User Sender { get; set; }

        public User Receiver { get; set; }

        public string Message { get; set; }

        public Email(User sender, User receiver, string message)
        {
            Sender = sender;
            Receiver = receiver;
            Message = message;
        }
    }
}
