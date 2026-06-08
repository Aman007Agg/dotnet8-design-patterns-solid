using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    internal class NotificationManager
    {
        private readonly INotificationService notificationService;
        public NotificationManager(INotificationService notificationService)
        {  this.notificationService = notificationService;
        }

        public void Notify(string message)
        {
            notificationService.Send(message);
        }
    }
}
