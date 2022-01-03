// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3
{
    // CMS_FileTag
    public class CmsFileTag
    {
        public int FileId { get; set; } // FileId (Primary key)
        public int TagId { get; set; } // TagId (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent CmsFile pointed by [CMS_FileTag].([FileId]) (FK_CMS_FileTag_CMS_File)
        /// </summary>
        public virtual CmsFile CmsFile { get; set; } // FK_CMS_FileTag_CMS_File

        /// <summary>
        /// Parent CmsTag pointed by [CMS_FileTag].([TagId]) (FK_CMS_FileTag_CMS_Tag)
        /// </summary>
        public virtual CmsTag CmsTag { get; set; } // FK_CMS_FileTag_CMS_Tag
    }

}
// </auto-generated>
