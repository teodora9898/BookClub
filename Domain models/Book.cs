using System;

namespace BookClub.Domain_models
{
    public class Book
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public string YearOfPublish { get; set; }
        public string Summary { get; set; }
        public string NumberOfPages { get; set; }
    }
}
