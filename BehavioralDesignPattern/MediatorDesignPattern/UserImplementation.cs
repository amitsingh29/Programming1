﻿//-----------------------------------------------------------------------
// <copyright file="UserInterface.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.MediatorDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

   public class UserImplementation : User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserImplementation"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        /// <param name="name">The name.</param>
        public UserImplementation(IChatMediator mediator, string name) : base(mediator, name)
        {
        }

        /// <summary>
        /// Receives the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public override void Receive(string msg)
        {
            Console.WriteLine(this.name + ": Received Message: " + msg);
        }

        /// <summary>
        /// Sends the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public override void Send(string msg)
        {
            Console.WriteLine(this.name + ": Send Message: " + msg);
            mediator.SendMessage(msg, this);
        }
    }
}
