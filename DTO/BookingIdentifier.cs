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
        protected long Id { get; private set; }
        /// <summary>
        /// Constructor to create a specific booking identifier.
        /// </summary>
        /// <param name="id"><inheritdoc cref="Id"/></param>
        public BookingIdentifier(long id)
        {
            Id = id;
        }
    }
}
