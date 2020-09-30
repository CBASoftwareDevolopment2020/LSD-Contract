using LSD_Contract.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSD_Contract.Managers
{
    /// <summary>
    /// An interface for all Flight related endpoints.
    /// </summary>
    interface IFlightManager
    {
        /// <summary>
        /// Get a list of flight details.
        /// </summary>
        /// <param name="flights">The list of flights you wish to get details from.</param>
        /// <returns>ICollection of FlightDetails</returns>
        ICollection<FlightDetail> GetFlightDetails(ICollection<FlightIdentifier> flights);

        /// <summary>
        /// Returns all flights between two airports on a given day.
        /// </summary>
        /// <param name="IATAcode1">The IATACode airport code of the first airport.</param>
        /// <param name="IATAcode2">The IATACode airport code of the second airport.</param>
        /// <param name="date">The date of the flights your wish to see.</param>
        /// <returns>ICollection of FlightDetails</returns>
        ICollection<FlightDetail> GetSchedule(string IATAcode1, string IATAcode2, DateTime date);
    }
}
