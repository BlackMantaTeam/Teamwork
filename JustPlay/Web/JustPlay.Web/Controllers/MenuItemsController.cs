namespace JustPlay.Web.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Data.Models;
    using Models;
    using Data.Repositories;

    public class MenuItemsController : ApiController
    {
        private readonly IRepository<MenuItem> menuItems;
        private readonly IRepository<User> users;

        public MenuItemsController()
        {
            var db = new JustPlayDbContext();
            this.menuItems = new GenericRepository<MenuItem>(db);
            this.users = new GenericRepository<User>(db);
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var result = this.menuItems
                .All()
                .Select(MenuItemsViewModel.FromModel)
                .ToList();

            return this.Ok(result);
        }

        [HttpGet]
        [Route("api/MenuItems/Get/{category}")]
        public IHttpActionResult GetMenuItem(string category)
        {
            if (string.IsNullOrEmpty(category))
            {
                return this.BadRequest("Category cannot  be null or empty");
            }

            var result = this.menuItems
                .All()
                .Where(s => s.Category == category)
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        //[Authorize]
        [HttpPost]
        public IHttpActionResult CreateMenuItem(MenuItemsViewModel model)
        {
            var currentUser = this.users
                .All()
                .FirstOrDefault(u => u.UserName == this.User.Identity.Name);

            var newMenuItem = new MenuItem
            {
                IconFile = model.IconFile,
                Category = model.Category
            };

            this.menuItems.Add(newMenuItem);
            this.menuItems.SaveChanges();
            return this.Ok(newMenuItem.Id);
        }
    }
}