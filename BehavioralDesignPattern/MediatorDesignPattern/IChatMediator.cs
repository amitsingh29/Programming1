//-----------------------------------------------------------------------
// <copyright file="IChatMediator.cs" company="BridgeLabz">
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
    /// IChatMediator class
    /// </summary>
    public interface IChatMediator
    {
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="user">The user.</param>
        public void SendMessage(string message, User user);

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void AddUser(User user);
    }
}
