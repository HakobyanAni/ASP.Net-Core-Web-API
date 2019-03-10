using System;

namespace Data_Access_Layer.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int PublicationDate { get; set; }
        public int NumberOfPages { get; set; }
    }
}
