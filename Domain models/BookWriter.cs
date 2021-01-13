using System;
using System.Collections.Generic;
using System.Text;

namespace BookClub.Domain_models
{
    public class BookWriter
    {
        public Book Book { get; set; }
        public Writer Writer { get; set; }
        public String TimeSpanOfWritingBook { get; set; }
        public String InterestingFacts { get; set; }

        //todo razmisli da li treba da uacis listu koautora
    }
}
