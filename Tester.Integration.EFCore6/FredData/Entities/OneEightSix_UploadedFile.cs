// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V6Fred
{
    // UploadedFile
    public class OneEightSix_UploadedFile
    {
        public int Id { get; set; } // Id (Primary key)
        public string FullPath { get; set; } // FullPath

        // Reverse navigation

        /// <summary>
        /// Child OneEightSix_Issues where [Issue].[ConsentDocumentId] point to this entity (FK_Issue_UploadedFileConsentDocument)
        /// </summary>
        public virtual ICollection<OneEightSix_Issue> OneEightSix_Issues_ConsentDocumentId { get; set; } // Issue.FK_Issue_UploadedFileConsentDocument

        /// <summary>
        /// Child OneEightSix_Issues (Many-to-Many) mapped by table [IssueUploadedFile]
        /// </summary>
        public virtual ICollection<OneEightSix_Issue> OneEightSix_Issues_IssueId { get; set; } // Many to many mapping

        public OneEightSix_UploadedFile()
        {
            OneEightSix_Issues_ConsentDocumentId = new List<OneEightSix_Issue>();
            OneEightSix_Issues_IssueId = new List<OneEightSix_Issue>();
        }
    }

}
// </auto-generated>
