using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation_layer_Web_API_.Models
{
    public class GithubProfileModel
    {
        public string UserName { get; set; }
        public string Url { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string BlogOrWebsite { get; set; }
        public int StarsCount { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
