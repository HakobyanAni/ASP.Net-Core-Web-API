using System.Collections.Generic;
using Data_Access_Layer.Entities;

namespace WebAPI.Models
{
    public class AuthorModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDeathDate { get; set; }
        public string Nationality { get; set; }
        public List<Book> Books { get; set; }
    }
}
