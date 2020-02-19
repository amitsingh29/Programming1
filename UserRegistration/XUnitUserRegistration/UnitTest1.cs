//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace XUnitUserRegistration
{
    using System;
    using Xunit;

    /// <summary>
    /// UnitTest1 class
    /// </summary>
    public class UnitTest1
    {
        /// <summary>
        /// checks the test case
        /// </summary>
        [Fact]
        public void TestFirstName()
        { 
            Assert.True(UserRegistration.FirstName("Amit"));
        }

        /// <summary>
        /// checks the test case
        /// </summary>
        [Fact]
        public void TestFirstNameNull()
        {
            Assert.False(UserRegistration.FirstName(string.Empty));
        }

        /// <summary>
        /// checks the test case
        /// </summary>
        [Fact]
        public void TestLastName()
        {
            Assert.True(UserRegistration.LastName("Singh"));
        }

        /// <summary>
        /// checks the test case
        /// </summary>
        [Fact]
        public void TestLastNameNull()
        {
            Assert.False(UserRegistration.LastName(string.Empty));
        }

        /// <summary>
        /// checks the test case
        /// </summary>
        [Fact]
        public void TestEmailId()
        {
            Assert.True(UserRegistration.EmailId("amit.singh29@gmail.com"));
        }

        /// <summary>
        /// checks the test case
        /// </summary>
        [Fact]
        public void TestEmailIdNull()
        {
            Assert.False(UserRegistration.EmailId(string.Empty));
        }

        /// <summary>
        /// checks the test case
        /// </summary>
        [Fact]
        public void TestPassword()
        {
            Assert.True(UserRegistration.Password("Admin@123"));
        }

        /// <summary>
        /// checks the test case
        /// </summary>
        [Fact]
        public void TestPasswordNull()
        {
            Assert.False(UserRegistration.Password(string.Empty));
        }
    }
}
