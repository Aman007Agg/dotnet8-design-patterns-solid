using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    internal class SMSService: INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"message from Sms: {message}");
        }
    }
}
