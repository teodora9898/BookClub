using BookClub.Domain_models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookClub.Help
{
    public static class Global
    {
        private static  User activeUser;

        public static User ActiveUser
        {
            get { return activeUser; }
            set { activeUser = value; }
        }

    }
}
