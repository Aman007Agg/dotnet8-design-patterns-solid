using ObserverPattern;

class Program
{
    static void Main()
    {
        // Create Observers
        EmailService email = new EmailService();
        SMSService sms = new SMSService();
        Dashboard dashboard = new Dashboard();

        // Subscribe Observers to the Subject
        Stock reliance = new Stock();
        reliance.Subscribe(email);
        reliance.Subscribe(sms);
        reliance.Subscribe(dashboard);

        reliance.Price = 2600; // This will trigger notifications to all observers


    }
}