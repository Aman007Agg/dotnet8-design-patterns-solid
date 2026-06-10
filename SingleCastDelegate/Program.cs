using System;

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
    public static void Main()
    {
        Console.WriteLine("1. Email");
        Console.WriteLine("2. SMS");
        Console.WriteLine("3. Whatsapp");

        int choice = int.Parse(Console.ReadLine());
        NotificationDelegate notify;
        if (choice == 1)
        {
            notify = SendEmail;
        }
        else if (choice == 2)
        {
            notify = SendSMS;
        }
        else if (choice == 3)
        {
            notify = SendWhatsapp;
        }
        else
        {
            Console.WriteLine("Invalid Request");
            return;
        }

        notify("Order Notified");
    }
}