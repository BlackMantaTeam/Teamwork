namespace JustPlay.Web.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Data.Models;
    using Models;
    using Data.Repositories;

    public class SoundsController : ApiController
    {
        private readonly IRepository<Sound> sounds;
        private readonly IRepository<User> users;

        public SoundsController()
        {
            var db = new JustPlayDbContext();
            this.sounds = new GenericRepository<Sound>(db);
            this.users = new GenericRepository<User>(db);
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var result = this.sounds
                .All()
                .Select(SoundsViewModel.FromModel)
                .ToList();

            return this.Ok(result);
        }

        [HttpGet]
        [Route("api/Sounds/Get/{title}")]
        public IHttpActionResult GetSound(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                return this.BadRequest("Sound cannot  be null or empty");
            }

            var result = this.sounds
                .All()
                .Select(SoundsViewModel.FromModel)
                .Where(s => s.Title == title)
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        //[Authorize]
        [HttpPost]
        public IHttpActionResult CreateSound(SoundsViewModel model)
        {
            var currentUser = this.users
                .All()
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

            this.sounds.Add(newSound);
            this.sounds.SaveChanges();
            return this.Ok(newSound.Id);
        }
    }
}
