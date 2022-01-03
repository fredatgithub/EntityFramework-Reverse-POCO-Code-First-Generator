// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V6Fred
{
    // Attendee
    public class Attendee
    {
        public long AttendeeId { get; set; } // AttendeeID (Primary key)
        public string Lastname { get; set; } // Lastname (length: 50)
        public string Firstname { get; set; } // Firstname (length: 50)
        public int? PhoneCountryId { get; set; } // PhoneCountryID

        // Foreign keys

        /// <summary>
        /// Parent Country pointed by [Attendee].([PhoneCountryId]) (FK_Attendee_PhoneCountry)
        /// </summary>
        public virtual Country Country { get; set; } // FK_Attendee_PhoneCountry
    }

}
// </auto-generated>
