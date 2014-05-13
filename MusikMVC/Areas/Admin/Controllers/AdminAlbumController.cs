using Nwd.BackOffice.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MusikMVC.Areas.Admin.Controllers
{
    public class AdminAlbumController : Controller
    {
        
        [IsSuperAdmin]
        [HttpGet]
        public ActionResult List()
        {
            AlbumRepository albumRepository = new AlbumRepository();
            List<Nwd.BackOffice.Model.Album> listAlbums = albumRepository.GetAllAlbums();
            return View(listAlbums);
        }

        [IsSuperAdmin]
        [HttpGet]
        public ActionResult Delete(int id)
        {
            AlbumRepository albumRepository = new AlbumRepository();
            var albumToDelete = albumRepository.GetAllAlbums().FirstOrDefault(x => x.Id == id);
            if (albumToDelete != null)
            {
                albumRepository.DeleteAlbum(albumToDelete);
                return Redirect("/Admin/Album/List");
            }
            else
            {
                return HttpNotFound();
            }
        }

        [IsSuperAdmin]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            throw new Exception("dd");
            AlbumRepository albumRepository = new AlbumRepository();
            var albumToEdit = albumRepository.GetAllAlbums().FirstOrDefault(x => x.Id == id);
            if (albumToEdit != null)
            {
                return View(albumToEdit);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [IsSuperAdmin]
        [HttpPost]
        public ActionResult Edit(Nwd.BackOffice.Model.Album album)
        {
            AlbumRepository albumRepository = new AlbumRepository();

            if (ModelState.IsValid)
            {
                albumRepository.EditAlbum(HttpContext.Server, album);
                return RedirectToRoute("list");
            }
            else
            {
                return View(album);
            }
        }
    }
}