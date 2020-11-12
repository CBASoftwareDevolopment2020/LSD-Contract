using System;
using System.Collections.Generic;
using System.Text;

namespace LSD_Contract.DTO
{
    public class PassengerDetail
    {
        /// <summary>
        /// Passenger name is in all capital letters, as written in their passport
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Email of the passenger. Must be formatted like a valid email.
        /// </summary>
        public string Email { get; private set; }
        /// <summary>
        /// Constructor to create an instance of a detailed passenger
        /// </summary>
        /// <param name="name"><inheritdoc cref="Name"/></param>
        /// <param name="email"><inheritdoc cref="Email"/></param>
        public PassengerDetail(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
