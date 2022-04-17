using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop1.Models;

namespace Shop1.Controllers
{
    public class MyshopController : Controller
    {
        private static List<Myshop> _myshop = new List<Myshop>();
        // GET: MyshopController
        public ActionResult Index()
        {
            return View(_myshop);
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
        public ActionResult Create(Myshop collection)
        {
            try
            {
                _myshop.Add(collection);
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
