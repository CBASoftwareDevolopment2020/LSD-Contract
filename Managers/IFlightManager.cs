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
        /// <param name="flights">The list of flights you wish to get details from</param>
        /// <returns>ICollection of FlightDetails</returns>
        ICollection<FlightDetail> GetFlightDetails(ICollection<FlightIdentifier> flights);

    }
}
