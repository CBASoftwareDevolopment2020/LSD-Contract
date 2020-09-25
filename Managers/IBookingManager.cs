using LSD_Contract.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSD_Contract.Managers
{
    /// <summary>
    /// An interface for all Flight related endpoints.
    /// </summary>
    interface IBookingManager
    {
        /// <summary>
        /// Make a booking with the provided booking details.
        /// </summary>
        /// <param name="booking">The booking you wish to make.</param>
        /// <returns>BookingDetail of the created booking.</returns>
        BookingDetail MakeBooking(BookingDetail booking);
    }
}
