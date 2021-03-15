using System;

namespace BookClub.Domain_models
{
    public class UserReview
    {
        public User User { get; set; }
        public Review Review { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
