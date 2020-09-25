using LSD_Contract.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSD_Contract.Managers
{
    interface IBookingManager
    {
        BookingDetail MakeBooking(BookingDetail booking);
    }
}
