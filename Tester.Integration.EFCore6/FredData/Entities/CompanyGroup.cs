// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V6Fred
{
    // CompanyGroup
    public class CompanyGroup
    {
        public int CogId { get; set; } // cogID (Primary key)
        public string CogCompanyGroupName { get; set; } // cogCompanyGroupName (length: 50)
        public DateTime? CogValidFrom { get; set; } // cogValidFrom
        public DateTime? CogValidTo { get; set; } // cogValidTo

        // Reverse navigation

        /// <summary>
        /// Child Companies where [Company].[cocogID] point to this entity (FK_Company_CompanyGroup)
        /// </summary>
        public virtual ICollection<Company> Companies { get; set; } // Company.FK_Company_CompanyGroup

        public CompanyGroup()
        {
            Companies = new List<Company>();
        }
    }

}
// </auto-generated>
