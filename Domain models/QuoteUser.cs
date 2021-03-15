using System;
using System.Collections.Generic;
using System.Text;

namespace BookClub.Domain_models
{
    public class QuoteUser
    {
        public Quote Quote { get; set; }
        public User User { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
