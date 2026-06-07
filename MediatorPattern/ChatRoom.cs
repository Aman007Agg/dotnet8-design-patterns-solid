using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    internal class ChatRoom: IChatMediator
    {
        private List<User> users = new List<User>();
        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in users)
            {
                if (user != sender)
                {
                    user.Receive($"{sender.Name}: {message}");
                }
            }
        }
    }
}
