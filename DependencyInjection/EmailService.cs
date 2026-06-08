using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    internal class EmailService:INotificationService
    {
        public void Send(string message)
        {
            Console.Write($"Message sent from email: {message}");
        }
    }
}
