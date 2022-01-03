// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3
{
    // CODE_MeetingTopicDetails
    public class CodeMeetingTopicDetail
    {
        public int Id { get; set; } // id (Primary key)
        public int IdReuniao { get; set; } // id_reuniao
        public int? OrdTrab { get; set; } // ord_trab
        public string Assunto { get; set; } // assunto (length: 250)
        public string Desenvolvimento { get; set; } // desenvolvimento
        public string Origem { get; set; } // origem (length: 5)
        public int? IdOrigem { get; set; } // id_origem
        public int? Estado { get; set; } // Estado
        public int CompanyId { get; set; } // CompanyID
        public DateTime DateCreated { get; set; } // DateCreated
        public DateTime? DateChanged { get; set; } // DateChanged

        // Foreign keys

        /// <summary>
        /// Parent CodeParamMeetingTopicDetailSource pointed by [CODE_MeetingTopicDetails].([Origem]) (FK_CODE_MeetingTopicDetails_CODE_PARAM_MeetingTopicDetailSource)
        /// </summary>
        public virtual CodeParamMeetingTopicDetailSource CodeParamMeetingTopicDetailSource { get; set; } // FK_CODE_MeetingTopicDetails_CODE_PARAM_MeetingTopicDetailSource
    }

}
// </auto-generated>
