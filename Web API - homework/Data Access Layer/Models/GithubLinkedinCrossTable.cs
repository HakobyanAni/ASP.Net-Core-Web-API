using System;
using System.Collections.Generic;

namespace Data_Access_Layer.Models
{
    public partial class GithubLinkedinCrossTable
    {
        public int Id { get; set; }
        public int GithubUserId { get; set; }
        public int LinkedinUserId { get; set; }
    }
}
