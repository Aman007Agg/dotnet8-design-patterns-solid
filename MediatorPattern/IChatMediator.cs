using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// The IChatMediator interface defines the contract for the mediator in the chat application.
    /// It declares a method for sending messages, which will be implemented by the concrete mediator class. 
    /// The mediator will handle the communication between different users, allowing them to send messages without directly referencing each other,
    /// thus promoting loose coupling and separation of concerns.
    /// </summary>
    internal interface IChatMediator
    {
        void SendMessage(string message, User sender);
    }
}
