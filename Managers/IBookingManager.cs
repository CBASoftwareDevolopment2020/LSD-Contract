using LSD_Contract.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSD_Contract.Managers
{
    /// <summary>
    /// An interface for all Flight related endpoints.
    /// </summary>
    public interface IBookingManager
    {
        /// <summary>
        /// Make a booking with the provided booking details.
        /// </summary>
        /// <param name="booking">The booking you wish to make.</param>
        /// <returns>BookingDetail of the created booking.</returns>
        BookingDetail MakeBooking(BookingDetail booking);

        /// <summary>
        /// Cancels a booking based on a Passenger Name Record.
        /// </summary>
        /// <param name="PassengerNameRecord"><inheritdoc cref="PassengerNameRecord"/></param>
        /// <returns>A BookingIdentifier of the cancelled booking.</returns>
        BookingIdentifier CancelBooking(BookingIdentifier PassengerNameRecord);

        /// <summary>
        /// Retrieves a booking given the Passenger Name Record.
        /// </summary>
        /// <param name="PassengerNameRecord"><inheritdoc cref="PassengerNameRecord"/>.</param>
        /// <returns>A BookingDetail with booking information.</returns>
        BookingDetail SeeBooking(BookingIdentifier PassengerNameRecord);
    }
}
