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
        [Route("api/Sounds/Get/{name}")]
        public IHttpActionResult GetSound(string sound)
        {
            if (string.IsNullOrEmpty(sound))
            {
                return this.BadRequest("Sound cannot  be null or empty");
            }

            var result = this.sounds
                .All()
                .Where(s => s.Name == sound)
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
