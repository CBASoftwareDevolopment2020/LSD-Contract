using System;
using System.Collections.Generic;
using System.Text;

namespace LSD_Contract.DTO
{
    class FlightDetail : FlightIdentifier
    {
        /// <summary>
        /// Departure datetime of the flight
        /// </summary>
        public DateTime DepartureTime { get; private set; }
        /// <summary>
        /// Arrival datetime of the flight
        /// </summary>
        public DateTime ArrivalTime { get; private set; }
        /// <summary>
        /// The number of available seats on the flight
        /// </summary>
        public int SeatCount { get; private set; }
        /// <summary>
        /// Price in euros
        /// </summary>
        public int Price { get; private set; }
        /// <summary>
        /// Returns the full code used to identify a Flight. It consists of the carrier code followed by three digits.
        /// </summary>
        public string GetFlightNumber => FlightCarrierIdentifier + FlightNumber;

        /// <summary>
        /// An instance of the flight
        /// </summary>
        /// <param name="departureTime"><inheritdoc cref="DepartureTime"/></param>
        /// <param name="arrivalTime"><inheritdoc cref="ArrivalTime"/></param>
        /// <param name="seatCount"><inheritdoc cref="SeatCount"/></param>
        /// <param name="price"><inheritdoc cref="Price"/></param>
        /// <param name="flightNumber"><inheritdoc cref="flightNumber"/></param>
        /// <param name="flightCarrierIdentifier"><inheritdoc cref="flightCarrierIdentifier"/></param>
        public FlightDetail(DateTime departureTime, DateTime arrivalTime, int seatCount, int price, string flightNumber, CarrierIdentifier flightCarrierIdentifier) : base(flightNumber, flightCarrierIdentifier)
        {
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            SeatCount = seatCount;
            Price = price;
        }
    }
}
