//-----------------------------------------------------------------------
// <copyright file="ChatMediatorImplementation.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.MediatorDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ChatMediatorImplementation : IChatMediator
    {
        /// <summary>
        /// The users
        /// </summary>
        private List<User> users;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMediatorImplementation"/> class.
        /// </summary>
        public ChatMediatorImplementation()
        {
            this.users = new List<User>();
        }

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void AddUser(User user)
        {
            this.users.Add(user);
        }

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="user">The user.</param>
        public void SendMessage(string message, User user)
        {
            foreach (User u in this.users)
            {
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
