// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3
{
    // MultipleKeys
    public class MultipleKey
    {
        public int UserId { get; set; } // UserId (Primary key)
        public int FavouriteColourId { get; set; } // FavouriteColourId (Primary key via unique index )
        public int BestHolidayTypeId { get; set; } // BestHolidayTypeId (Primary key)
        public int BankId { get; set; } // BankId
        public int CarId { get; set; } // CarId
    }

}
// </auto-generated>
