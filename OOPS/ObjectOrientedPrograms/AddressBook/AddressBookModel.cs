using System;
using System.Collections.Generic;
using System.Text;
//using System.Collections;

namespace ObjectOrientedPrograms.AddressBook
{
    class AddressBookModel
    {
        private String name;
        private String state;
        private String dist;
        private String email;
        private long phone;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBookModel"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="state">The state.</param>
        /// <param name="dist">The dist.</param>
        /// <param name="phone">The phone.</param>
        /// <param name="email">The email.</param>
        
        public AddressBookModel(String name, String state, String dist, long phone, String email)
        {
            this.name = name;
            this.dist = dist;
            this.state = state;
            this.phone = phone;
            this.email = email;
        }
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }
        public string Dist
        {
            get { return this.dist; }
            set { this.dist = value; }
        }
        public long Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
      
        public static void CreatObject(string name, string state, string dist, long phone, string email)
        {
            AddressBookModel a = new AddressBookModel(name, state, dist, phone, email);
           
            var d = JsonReadFile.Read();

            d.AddressList(a);

            JsonWriteFile.Write(d);
        }
    }
}
