//-----------------------------------------------------------------------
// <copyright file="UserRegistration.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------
namespace XUnitUserRegistration
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// UserRegistration class
    /// </summary>
    public class UserRegistration
    {
        /// <summary>
        /// this is FirstName method
        /// </summary>
        /// <param name="input">string input</param>
        /// <returns>boolean value</returns>
        public static bool FirstName(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z]+$");
        }

        /// <summary>
        /// this is LastName method
        /// </summary>
        /// <param name="input">string input</param>
        /// <returns>boolean value</returns>
        public static bool LastName(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z]+$");
        }

        /// <summary>
        /// this is Age method
        /// </summary>
        /// <param name="input">string input</param>
        /// <returns>boolean value</returns>
        public static bool Age(string input)
        {
            return Regex.IsMatch(input, "^[0-9]+$");
        }

        /// <summary>
        /// this is EmailId method
        /// </summary>
        /// <param name="input">string input</param>
        /// <returns>boolean value</returns>
        public static bool EmailId(string input)
        {
            return Regex.IsMatch(input, "^([a-z0-9._]+)@(gmail|outlook|yahoo).(com|org)$");
        }

        /// <summary>
        /// this is Password method
        /// </summary>
        /// <param name="input">string input</param>
        /// <returns>boolean value</returns>
        public static bool Password(string input)
        {
            return Regex.IsMatch(input, "^(^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$)");
        }
    }
}