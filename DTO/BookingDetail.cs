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
        /// <param name="eTicketIdentification"><inheritdoc cref="ETicketIdentification"/></param>
        /// <param name="passengers"><inheritdoc cref="Passengers"/></param>
        /// <param name="id"><inheritdoc cref="id"/></param>
        /// <param name="PassengerNameRecord"><inheritdoc cref="PassengerNameRecord"/></param>
        public BookingDetail(string eTicketIdentification, ICollection<PassengerDetail> passengers, long id, string PassengerNameRecord) : base(PassengerNameRecord)
        {
            ETicketIdentification = eTicketIdentification;
            Passengers = passengers;
        }
    }

}
