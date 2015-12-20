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
    }
}
