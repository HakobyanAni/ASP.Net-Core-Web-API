using System;

namespace WebAPI.Models
{
    public class BookModel
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int PublicationDate { get; set; }
        public int NumberOfPages { get; set; }
    }
}
