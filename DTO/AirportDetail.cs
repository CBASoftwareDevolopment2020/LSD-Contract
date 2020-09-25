using System;
using System.Collections.Generic;
using System.Text;

namespace LSD_Contract.DTO
{
    /// <summary>
    /// AirportDTO with all attributes
    /// </summary>
    class AirportDetail : AirportIdentifier
    {
        /// <summary>
        /// Timezone based on GMT values
        /// </summary>
        public int TimeZone { get; private set; }

        /// <summary>
        /// The constructor to create an instance of AirportDetail
        /// </summary>
        /// <param name="timeZone"><inheritdoc cref="TimeZone"/></param>
        /// <param name="iataCode"><inheritdoc cref="iataCode"/></param>
        public AirportDetail(int timeZone, string iataCode) : base(iataCode)
        {
            TimeZone = timeZone;
        }
    }
}
