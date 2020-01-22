//-----------------------------------------------------------------------
// <copyright file="User.cs" company="BridgeLabz">
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
    /// User class
    /// </summary>
    public abstract class User
    {
        /// <summary>
        /// The mediator
        /// </summary>
        protected IChatMediator mediator;

        /// <summary>
        /// The name
        /// </summary>
        protected string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        /// <param name="name">The name.</param>
        public User(IChatMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        /// <summary>
        /// Sends the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public abstract void Send(string msg);

        /// <summary>
        /// Receives the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public abstract void Receive(string msg);
    }
}
