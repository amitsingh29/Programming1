using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace ObjectOrientedPrograms
{
    class RegularExpression
    {
        /// <summary>
        /// 
        /// </summary>
        public void stringReplace()
        {
            string data = "Hello <<Name>>," +
                            "\nWe have your full name as <<full name>> in our system." +
                            "\nyour contact number is 91 - xxxxxxxxxx." +
                            "\nPlease,let us know in case clarification" +
                            "\nThank you BridgeLabz" +
                            "\ndd/mm/yyyy.";

            string userName = "<<Name>>";
            string userFullName = "<<full name>>";
            string userContactNumber = "xxxxxxxxxx";
            string randomDate = "dd/mm/yyyy";

            Console.WriteLine("please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("please enter your Full Name:");
            string fullName = Console.ReadLine();
            Console.WriteLine("please enter your contact Number:");
            string contactNumber = Console.ReadLine();


            if (!Regex.IsMatch(userName, "^[a-zA-Z]*$") && !Regex.IsMatch(userFullName, "^[a-zA-Z]+[ ]{1}[a-zA-Z]+$") && Regex.IsMatch(userContactNumber, "^[0-9]{10}$"))
            {

                Console.WriteLine("Invalid Input!!!!!");
            }
            else
            {
                data = replacePattern(data, name, userName);
                data = replacePattern(data, fullName, userFullName);
                data = replacePattern(data, contactNumber, userContactNumber);
                string currentDate = DateTime.Now.ToString("MM/dd/yyyy");
                data = replacePattern(data, currentDate, randomDate);
                Console.WriteLine(data);
            }
        }

        /// <summary>
        /// Replaces the pattern.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="check">The check.</param>
        /// <param name="pattern">The pattern.</param>
        /// <returns></returns>
        public string replacePattern(string text, string check, string pattern)
        {

            Regex regex = new Regex(pattern);
            string replacedString = regex.Replace(text, check);
            return replacedString;
        }

    }
}
