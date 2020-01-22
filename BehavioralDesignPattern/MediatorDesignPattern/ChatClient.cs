//-----------------------------------------------------------------------
// <copyright file="ChatClient.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.MediatorDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ChatClient class
    /// </summary>
    public class ChatClient
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            IChatMediator mediator = new ChatMediatorImplementation();
            User user1 = new UserImplementation(mediator, "Amit");
            User user2 = new UserImplementation(mediator, "Mayank");
            User user3 = new UserImplementation(mediator, "Saad");
            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);

            user1.Send("Hi Everyone!!!");
        }
    }
}