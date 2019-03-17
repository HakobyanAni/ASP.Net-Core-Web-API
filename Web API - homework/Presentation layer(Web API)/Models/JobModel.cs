using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation_layer_Web_API_.Models
{
    public class JobModel
    {
        public string Title { get; set; }
        public string Email { get; set; }
        public DateTime? Deadline { get; set; }
        public string EmploymentTerm { get; set; }
        public string TimeType { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Responsibilities { get; set; }
        public string RequiredQualifications { get; set; }
        public string AdditionalInformation { get; set; }
        public int CompanyId { get; set; }
    }
}
