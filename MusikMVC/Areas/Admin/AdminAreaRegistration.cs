using System.Web.Mvc;

namespace MusikMVC.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AdminAlbumList",
                "Admin/Album/List",
                new { controller = "AdminAlbumController", action = "List", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "AdminAlbumCreate",
                "Admin/Album/Create",
                new { controller = "AlbumController", action = "Create", id = UrlParameter.Optional }
           );

            context.MapRoute(
                "AdminAlbumEdit",
                "Admin/Album/Edit/{id}",
                new { controller = "AdminAlbumController", action = "Edit", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "AdminAlbumDelete",
                "Admin/Album/Delete/{id}",
                new { controller = "AdminAlbumController", action = "Delete" }
            );

            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}