using Nwd.BackOffice.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MusikMVC.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Admin/Album/Create
        [HttpGet]
        public ActionResult Create()
        {
            Nwd.BackOffice.Model.Album album = new Nwd.BackOffice.Model.Album();
            return View();
        }

        [HttpGet]
        public ActionResult List()
        {
            AlbumRepository albumRepository = new AlbumRepository();
            List<Nwd.BackOffice.Model.Album> listAlbums = albumRepository.GetAllAlbums();
            return View(listAlbums);
        }


        [HttpPost]
        public ActionResult Create(Nwd.BackOffice.Model.Album album)
        {

            if (ModelState.IsValid && album.Tracks != null)
            {
                var tracks = album.Tracks;
                AlbumRepository repository = new AlbumRepository();

                repository.CreateAlbum(album, HttpContext.Server);

            }
            return View();
        }
    }
}