using System;
using System.Collections.Generic;
using System.Text;

namespace LSD_Contract.DTO
{
    /// <summary>
    /// Class used to identify specific carriers
    /// </summary>
    public class CarrierIdentifier
    {
        /// <summary>
        /// Two letter code used to identify Carriers
        /// </summary>
        public string IATACode { get; private set; }
        /// <summary>
        /// Class used to identify specific carriers
        /// </summary>
        /// <param name="iataCode"><inheritdoc cref="IATACode"/></param>
        public CarrierIdentifier(string iataCode)
        {
            IATACode = iataCode;
        }
    }
}
