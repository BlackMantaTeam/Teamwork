namespace JustPlay.Web.Models
{
    using JustPlay.Data.Models;
    using System;
    using System.Linq.Expressions;

    public class MenuItemsViewModel
    {
        public string IconFile { get; set; }

        public string Category { get; set; }

        public static Expression<Func<MenuItem, MenuItemsViewModel>> FromModel
        {
            get
            {
                return mi => new MenuItemsViewModel
                {
                    IconFile = mi.IconFile,
                    Category = mi.Category
                };
            }
        }
    }
}