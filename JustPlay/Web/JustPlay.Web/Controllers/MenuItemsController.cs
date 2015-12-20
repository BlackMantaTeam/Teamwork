namespace JustPlay.Web.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Data.Models;
    using Models;

    public class MenuItemsController : ApiController
    {
        private readonly JustPlayDbContext db;

        public MenuItemsController()
        {
            this.db = new JustPlayDbContext();
        }

        public IHttpActionResult Get()
        {
            var result = this.db
                .MenuItems
                .Select(MenuItemsViewModel.FromModel)
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(string category)
        {
            if (string.IsNullOrEmpty(category))
            {
                return this.BadRequest("Category cannot  be null or empty");
            }

            var result = this.db
                .MenuItems
                .Where(s => s.Category == category)
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        //[Authorize]
        public IHttpActionResult Post(MenuItemsViewModel model)
        {
            var currentUser = this.db
                .Users
                .FirstOrDefault(u => u.UserName == this.User.Identity.Name);

            var newMenuItem = new MenuItem
            {
                IconFile = model.IconFile,
                Category = model.Category
            };

            db.MenuItems.Add(newMenuItem);
            db.SaveChanges();
            return this.Ok(newMenuItem.Id);
        }

    }
}