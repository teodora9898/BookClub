using System;

namespace BookClub.Domain_models
{
    public class Book
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Genre { get; set; }
        public String Publisher { get; set; }
        public String YearOfPublish { get; set; }
        public String Summary { get; set; }
        public String NumberOfPages { get; set; }
        
    }
}
