using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Shop1.Controllers
{
    public class MyshopController : Controller
    {
        // GET: MyshopController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MyshopController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MyshopController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyshopController/Create
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

        // GET: MyshopController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MyshopController/Edit/5
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

        // GET: MyshopController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MyshopController/Delete/5
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
