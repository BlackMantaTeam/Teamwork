namespace JustPlay.Web.Controllers
{
    using System.Web.Http;
    using JustPlay.Data;
    using Data.Repositories;
    using Data.Models;
    using System.Linq;

    public class UserController : ApiController
    {
        private readonly IRepository<User> users;

        public UserController()
        {
            var db = new JustPlayDbContext();
            this.users = new GenericRepository<User>(db);
        }

        [HttpGet]
        public IHttpActionResult GetUserProfile()
        {
            var result = this.users
                .All()
                .FirstOrDefault(u => u.UserName == this.User.Identity.Name);

            return this.Ok(result);
        }

        [HttpPost]
        [Route("api/User/Edit")]
        public IHttpActionResult SetProfilePic(string ImageUrl)
        {
            var user = this.users
                .All()
                .Where(x => x.UserName == this.User.Identity.Name)
                .FirstOrDefault();

            user.ImageUrl = ImageUrl;
            this.users.SaveChanges();

            return Ok();
        }
    }
}
