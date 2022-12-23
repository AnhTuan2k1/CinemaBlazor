using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaBlazor.Controllers
{
    public class ShowTimeController : Controller
    {
        // GET: ShowTimeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ShowTimeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShowTimeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShowTimeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShowTimeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShowTimeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShowTimeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShowTimeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
