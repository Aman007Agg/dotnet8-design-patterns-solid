using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// User is an abstract class that represents a participant in the chat application.
    /// It contains a reference to the IChatMediator, which allows it to communicate with other users through the mediator.
    /// </summary>
    internal abstract class User
    {
        protected IChatMediator mediator;
        public string Name
        {
            get;
        }

        public User(IChatMediator mediator, string name)
        {
            this.mediator = mediator;
            Name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);

    }
}
