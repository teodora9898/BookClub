using System;

namespace BookClub.Domain_models
{
    public class Book
    {
        public String id { get; set; }
        public String name { get; set; }
        public String genre { get; set; }
        public String publisher { get; set; }
        public String yearOfPublish { get; set; }
        public String summary { get; set; }
        public String numberOfPages { get; set; }
    }
}
