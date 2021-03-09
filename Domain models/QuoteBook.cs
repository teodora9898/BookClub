using System;
using System.Collections.Generic;
using System.Text;

namespace BookClub.Domain_models
{
    public class QuoteBook
    {
        public Quote Quote { get; set; }
        public Book Book { get; set; }
    }
}
