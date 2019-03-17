using System;
using System.Collections.Generic;

namespace Data_Access_Layer.Models
{
    public partial class LinkedinExperience
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string Time { get; set; }
        public int LinkedinProfileId { get; set; }
        public string Location { get; set; }

        public virtual LinkedinProfile LinkedinProfile { get; set; }
    }
}
