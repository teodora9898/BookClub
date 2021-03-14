using System;

namespace BookClub.Domain_models
{
    public class UserReviewComment
    {
        public User User { get; set; }
        public Review Review { get; set; }
        public String Comment { get; set; }
    }
}
