using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    internal interface INotificationService
    {
        void Send(string message);
    }
}
