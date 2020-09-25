using System;
using System.Collections.Generic;
using System.Text;

namespace LSD_Contract.DTO
{
    class FlightDetail
    {
        public DateTime DepartureTime { get; private set; }
        public DateTime ArrivalTime { get; private set; }
        public int SeatCount { get; private set; }
        public int Price { get; private set; }

        public FlightDetail(DateTime departureTime, DateTime arrivalTime, int seatCount, int price)
        {
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            SeatCount = seatCount;
            Price = price;
        }
    }
}
