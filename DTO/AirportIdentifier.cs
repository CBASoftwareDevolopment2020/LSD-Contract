using System;
using System.Collections.Generic;
using System.Text;

namespace LSD_Contract.DTO
{
    /// <summary>
    /// Class used to identify specific Airports
    /// </summary>
    class AirportIdentifier
    {
        /// <summary>
        /// Airport IATACode is identified by three letters, followed by three digits.
        /// </summary>
        protected string IATACode { get; private set; }

        /// <summary>
        /// Constructor for AirportIdentifier 
        /// </summary>
        /// <param name="iataCode"><inheritdoc cref="IATACode"/></param>
        public AirportIdentifier(string iataCode)
        {
            IATACode = iataCode;
        }
    }
}
