using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// UserBuilder class is responsible for constructing a User object step by step.
    /// It provides methods to set the properties of the User and a Build method to return the final User object.
    /// </summary>
    internal class UserBuilder
    {
        private User user;
        public UserBuilder()
        {
            user = new User();
        }

        //Add Fluent Methods
        public UserBuilder SetFirstName(string firstName)
        {
            user.FirstName = firstName;
            return this;
        }

        public UserBuilder SetLastName(string lastName)
        {
            user.LastName = lastName;
            return this;
        }

        public UserBuilder SetEmail(string email)
        {
            user.Email = email;
            return this;
        }

        public UserBuilder SetCountry(string country)
        {
            user.Country = country;
            return this;
        }

        public User Build()
        {
            return user;
        }
    }
}
