using System;
using System.Collections.Generic;
using System.Text;

namespace LSD_Contract.DTO
{
    /// <summary>
    /// Class for creating an instance of a detailed booking.
    /// </summary>
    class BookingDetail : BookingIdentifier
    {
        /// <summary>
        /// Single unique value to identify all passengers associated to the booking. It should consist of six alphanumeric characters and the first can't be a number.
        /// </summary>
        public string PassengerNameRecord { get; private set; }
        /// <summary>
        /// Can be either credit card number or frequent flyer number.
        /// </summary>
        public string ETicketIdentification { get; private set; }
        /// <summary>
        /// A list of passengers associated with the booking
        /// </summary>
        public ICollection<PassengerDetail> Passengers { get; private set; }


        /// <summary>
        /// Constructor to create an instance of a detailed booking.
        /// </summary>
        /// <param name="passengerNameRecord"><inheritdoc cref="PassengerNameRecord"/></param>
        /// <param name="eTicketIdentification"><inheritdoc cref="ETicketIdentification"/></param>
        /// <param name="passengers"><inheritdoc cref="Passengers"/></param>
        /// <param name="id"><inheritdoc cref="id"/></param>
        public BookingDetail(string passengerNameRecord, string eTicketIdentification, ICollection<PassengerDetail> passengers, long id) : base(id)
        {
            PassengerNameRecord = passengerNameRecord;
            ETicketIdentification = eTicketIdentification;
            Passengers = passengers;
        }
    }

}
