namespace JustPlay.Web.Models
{
    using System.Collections.Generic;
    using JustPlay.Data.Models;
    using System.Linq.Expressions;
    using System;
    public class UserViewModel
    {
        public string Username { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Sound> Sounds { get; set; }

        public static Expression<Func<User, UserViewModel>> FromModel
        {
            get
            {
                return u => new UserViewModel
                {
                    Username = u.UserName,
                    ImageUrl = u.ImageUrl,
                    Sounds = u.Sounds
                };
            }
        }
    }
}