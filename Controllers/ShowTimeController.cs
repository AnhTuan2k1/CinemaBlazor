using CinemaBlazor.Models;
using CinemaBlazor.Services;
using CinemaBlazor.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CinemaBlazor.Controllers
{
    public class ShowTimeController : Controller
    {
        IShowTimeRepository showtimeRepo;
        MovieContext db;

        public ShowTimeController(IShowTimeRepository _showtimeRepo, MovieContext _db)
        {
            showtimeRepo = _showtimeRepo;
            db = _db;
        }
        static Guid iid;

        [Authorize(Roles = "Admin")]
        public IActionResult GetShowTimesAdmin()
        {
            List<ShowTime> showtimes = showtimeRepo.GetAll();
            return View("AdminShowTimes", showtimes);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult GetShowTimesDetailsAdmin(Guid id)
        {
            ShowTimeViewModel ShowTimemodel = showtimeRepo.GetShowTimeByIdAdmin(id);

            ViewBag.Cinemas = new SelectList(db.Cinemas.ToList(), "Id", "Name");
            ViewBag.Categories = new SelectList(db.Categories.ToList(), "Id", "Name");
            ViewBag.Actors = new SelectList(db.Actors.ToList(), "Id", "Name");
            ViewBag.Producers = new SelectList(db.Producers.ToList(), "Id", "Name");

            return View("ShowtimeDetailsAdmin", ShowTimemodel);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewBag.Cinemas = new SelectList(db.Cinemas.ToList(), "Id", "Name");
            ViewBag.Categories = new SelectList(db.Categories.ToList(), "Id", "Name");
            ViewBag.Actors = new SelectList(db.Actors.ToList(), "Id", "Name");
            ViewBag.Producers = new SelectList(db.Producers.ToList(), "Id", "Name");

            return View(new MovieViewModel());

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ShowTimeViewModel showtimevm)
        {
            if (ModelState.IsValid)
            {
                showtimeRepo.Insert(showtimevm);
                return RedirectToAction("GetShowTimesAdmin", "Movie");
            }


            ViewBag.Cinemas = new SelectList(db.Cinemas.ToList(), "Id", "Name");
            ViewBag.Categories = new SelectList(db.Categories.ToList(), "Id", "Name");
            ViewBag.Actors = new SelectList(db.Actors.ToList(), "Id", "Name");
            ViewBag.Producers = new SelectList(db.Producers.ToList(), "Id", "Name");
            return View(showtimevm);

        }

        [Authorize(Roles = "Admin")]
        public ActionResult EditShowTimeFromAdmin(Guid id)

        {
            iid = id;
            ShowTimeViewModel ShowTimemodel = showtimeRepo.GetShowTimeByIdAdmin(id);

            ViewBag.Cinemas = new SelectList(db.Cinemas.ToList(), "Id", "Name");
            ViewBag.Categories = new SelectList(db.Categories.ToList(), "Id", "Name");
            ViewBag.Actors = new SelectList(db.Actors.ToList(), "Id", "Name");
            ViewBag.Producers = new SelectList(db.Producers.ToList(), "Id", "Name");



            return View("Edit", ShowTimemodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(ShowTimeViewModel editMovie)
        {

            Task<int> numOfRowsUpdated = showtimeRepo.update(editMovie, iid);
            return RedirectToAction("Getshowtimesadmin");
        }

        public ActionResult Delete(Guid id)
        {
            showtimeRepo.delete(id);
            return RedirectToAction("Getshowtimesadmin");

        }

    }
}
