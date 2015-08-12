using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotifyWebApi.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public UserProfileModel UserProfile { get; set; }
    }
}