using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// Concrete User class that implements the User abstract class.
    /// It represents a participant in the chat application who can send and receive messages through the mediator.
    /// </summary>
    internal class ChatUser: User
    {
        public ChatUser(IChatMediator mediator, string name) : base(mediator, name)
        {
        }
        public override void Send(string message)
        {
            mediator.SendMessage(message, this);
        }
        public override void Receive(string message)
        {
            Console.WriteLine($"{Name} received: {message}");
        }
    }
}
