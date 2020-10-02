using System;
using System.Collections.Generic;
using System.Text;

namespace LSD_Contract.DTO
{
    /// <summary>
    /// Class used to identify specific Bookings
    /// </summary>
    class BookingIdentifier
    {
        /// <summary>
        /// The unique Id of the booking
        /// </summary>
        protected string PassengerNameRecord { get; private set; }
        /// <summary>
        /// Constructor to create a specific booking identifier.
        /// </summary>
        /// <param name="PassengerNameRecord">A unique combination of numbers from the English alphabet and numbers, there is always six alphanumeric characters and the first can’t be a number.P</param>
        public BookingIdentifier(string PassengerNameRecord)
        {
            this.PassengerNameRecord = PassengerNameRecord;
        }
    }
}
