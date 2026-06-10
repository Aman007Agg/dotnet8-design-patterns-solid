using System;

public delegate void NotificationDelegate(string message);


/// <summary>
/// Anonymous Method
/// </summary>
class Program
{
    public static void Main()
    {
        NotificationDelegate notify = delegate (string message)
        {
            Console.WriteLine($"Email:{message}");
        };
        notify("Order Placed");


        NotificationDelegate notifyLambda = message =>
        {
            Console.WriteLine(message);
        };
        notify("Via Lambda Expressions");
    }
}