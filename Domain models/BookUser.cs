using System;
using System.Collections.Generic;
using System.Text;

namespace BookClub.Domain_models
{
    public class BookUser
    {
        public DateTime UploadDate { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }

    }
}
