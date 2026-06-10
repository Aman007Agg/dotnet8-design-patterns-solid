using System;
using System.Security.Cryptography.X509Certificates;
public delegate void NotificationDelegate(string message);

class Program
{
    public static void SendEmail(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
    public static void SendSMS(string message)
    {
        Console.WriteLine($"SMS: {message}");
    }
    public static void SendWhatsapp(string message)
    {
        Console.WriteLine($"Whatsapp: {message}");
    }
    public static void UpdateDashboard(string message)
    {
        Console.WriteLine($"Updated Dashboard: {message}");
    }
    public static void Main()
    {
        NotificationDelegate notify = SendEmail;
        notify += SendSMS;
        notify += SendWhatsapp;
        notify += UpdateDashboard;
        //notify -= SendEmail;
        notify("Order Placed");

    }
}