namespace JustPlay.Web.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Data.Models;
    using Models;

    public class SoundsController : ApiController
    {
        private readonly JustPlayDbContext db;

        public SoundsController()
        {
            this.db = new JustPlayDbContext();
        }

        public IHttpActionResult Get()
        {
            var result = this.db
                .Sounds
                .Select(SoundsViewModel.FromModel)
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(string sound)
        {
            if (string.IsNullOrEmpty(sound))
            {
                return this.BadRequest("Sound cannot  be null or empty");
            }

            var result = this.db
                .Sounds
                .Where(s => s.Name == sound)
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        //[Authorize]
        public IHttpActionResult Post(SoundsViewModel model)
        {
            var currentUser = this.db
                .Users
                .FirstOrDefault(u => u.UserName == this.User.Identity.Name);

            var newSound = new Sound
            {
                Title = model.Title,
                Genre = model.Genre,
                AudioSource = model.AudioSource,
                ImageSource = model.ImageSource,
                Artist = model.Artist,
                Name = model.Name,
                Rating = model.Rating
            };

            db.Sounds.Add(newSound);
            db.SaveChanges();
            return this.Ok(newSound.Id);
        }
    }
}
