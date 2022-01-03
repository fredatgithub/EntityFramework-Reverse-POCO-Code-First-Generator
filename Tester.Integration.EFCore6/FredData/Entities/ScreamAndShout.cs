// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V6Fred
{
    // ScreamAndShout
    public class ScreamAndShout
    {
        public int Id { get; set; } // id (Primary key)
        public decimal? KoeffVed { get; set; } // KoeffVed

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) ScreamAndShout pointed by [ScreamAndShout].[KateID] (KateFK)
        /// </summary>
        public virtual Kate_ScreamAndShout Kate_ScreamAndShout { get; set; } // ScreamAndShout.KateFK

        public ScreamAndShout()
        {
            KoeffVed = 0.5m;
        }
    }

}
// </auto-generated>
