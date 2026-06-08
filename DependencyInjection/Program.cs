using DependencyInjection;

class Program
{
    static void Main()
    {
        INotificationService emailService = new EmailService();
        NotificationManager manager = new NotificationManager(emailService);
        manager.Notify("Aman Agrawal");
    }
}