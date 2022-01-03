// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3
{
    // table with space and in columns
    public class TableWithSpaceAndInColumn
    {
        public int IdValue { get; set; } // id value (Primary key)

        // Reverse navigation

        /// <summary>
        /// Child TableMappingWithSpaces where [table mapping with space].[id value] point to this entity (space2FK)
        /// </summary>
        public virtual ICollection<TableMappingWithSpace> TableMappingWithSpaces { get; set; } // table mapping with space.space2FK

        public TableWithSpaceAndInColumn()
        {
            TableMappingWithSpaces = new List<TableMappingWithSpace>();
        }
    }

}
// </auto-generated>
