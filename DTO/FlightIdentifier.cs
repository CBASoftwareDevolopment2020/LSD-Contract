using System;
using System.Collections.Generic;
using System.Text;

namespace LSD_Contract.DTO
{
    /// <summary>
    /// Class used to identify unique flights
    /// </summary>
    class FlightIdentifier
    {
        /// <summary>
        /// flightCarrierIdentifier
        /// </summary>
        protected CarrierIdentifier FlightCarrierIdentifier { get; private set; }
        /// <summary>
        /// Unique identifier number of the flight
        /// </summary>
        protected string FlightNumber { get; private set; }
        /// <summary>
        /// Used to identify unique flights
        /// </summary>
        /// <param name="flightNumber">A unique number used to identify flights</param>
        /// <param name="flightCarrierIdentifier">The carriers unique identifier</param>
        public FlightIdentifier(string flightNumber, CarrierIdentifier flightCarrierIdentifier)
        {
            FlightNumber = flightNumber;
            FlightCarrierIdentifier = flightCarrierIdentifier;
        }

    
    }
}
