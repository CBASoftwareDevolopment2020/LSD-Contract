using System;
using System.Collections.Generic;
using System.Text;

namespace LSD_Contract.DTO
{
    class BookingDetail
    {
        public string PassengerNameRecord { get; private set; }
        public string ETicketIdentification { get; private set; }
        public ICollection<PassengerDetail> Passengers { get; private set; }

        public BookingDetail(string passengerNameRecord, string eTicketIdentification, ICollection<PassengerDetail> passengers)
        {
            PassengerNameRecord = passengerNameRecord;
            ETicketIdentification = eTicketIdentification;
            Passengers = passengers;
        }
    }

}
