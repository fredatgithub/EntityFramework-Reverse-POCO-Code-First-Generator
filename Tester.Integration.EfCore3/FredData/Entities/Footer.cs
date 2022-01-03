// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3
{
    // footer
    public class Footer
    {
        public int Id { get; set; } // ID (Primary key)
        public int OtherId { get; set; } // otherID
        public DateTime Added { get; set; } // added

        // Foreign keys

        /// <summary>
        /// Parent Header pointed by [footer].([Id], [OtherId]) (fooderFK)
        /// </summary>
        public virtual Header Header { get; set; } // fooderFK

        public Footer()
        {
            Added = DateTime.Now;
        }
    }

}
// </auto-generated>
