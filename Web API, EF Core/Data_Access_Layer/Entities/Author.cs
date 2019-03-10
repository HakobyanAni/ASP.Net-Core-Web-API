using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDeathDate { get; set; }
        public string Nationality { get; set; }
        public List<Book> Books { get; set; }
    }
}
