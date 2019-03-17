using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation_layer_Web_API_.Models
{
    public class CompanyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Industry { get; set; }
        public string NumberOfEmloyees { get; set; }
        public string DateOfFoundation { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string GoodlePlus { get; set; }
        public string Twitter { get; set; }
        public string Phone { get; set; }
        public int? Views { get; set; }
        public string Type { get; set; }
    }
}
