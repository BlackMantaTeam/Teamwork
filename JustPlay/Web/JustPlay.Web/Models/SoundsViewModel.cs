namespace JustPlay.Web.Models
{
    using JustPlay.Data.Models;
    using System;
    using System.Linq.Expressions;

    public class SoundsViewModel
    {
        public string Title { get; set; }
        public string Genre { get; set; }

        public string AudioSource { get; set; }
        public string ImageSource { get; set; }

        public string Artist { get; set; }
        public string Name { get; set; }

        public double Rating { get; set; }

        public static Expression<Func<Sound, SoundsViewModel>> FromModel
        {
            get
            {
                return s => new SoundsViewModel
                {
                    Title = s.Title,
                    Genre = s.Genre,
                    AudioSource = s.AudioSource,
                    ImageSource = s.ImageSource,
                    Artist = s.Artist,
                    Name = s.Name,
                    Rating = s.Rating
                };
            }
        }
    }
}
