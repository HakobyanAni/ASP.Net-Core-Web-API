using System;
using System.Collections.Generic;

namespace Data_Access_Layer.Models
{
    public partial class Proxy
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public string Type { get; set; }
    }
}
