using BulkyBook.Models;
using BulkyBookWeb.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{

    public class CatagoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CatagoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Catagory> objCatagoryList = _db.Catagories;
            return View(objCatagoryList);
        }

        //GET
        public IActionResult Create()
        {

            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]


        public IActionResult Create(Catagory obj)
        {
            if (obj.Name == obj.DispalyOrder.ToString())
            {
                ModelState.AddModelError("customError", "the displayOrder can't exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                _db.Catagories.Add(obj);
                TempData["success"] = "Catagory Deleted Successfully";
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var CatagoryFromDb = _db.Catagories.Find(id);
            /*    var CatagoryFromDbFirst = _db.Catagories.FirstOrDefault(u => u.Id == id);
                var CatagoryFromDbSingle = _db.Catagories.SingleOrDefault(u => u.Id == id);*/

            if (CatagoryFromDb == null)
            {
                return (NotFound());
            }

            return View(CatagoryFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]


        public IActionResult Edit(Catagory obj)
        {
            if (obj.Name == obj.DispalyOrder.ToString())
            {
                ModelState.AddModelError("customError", "the displayOrder can't exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                _db.Catagories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var CatagoryFromDb = _db.Catagories.Find(id);
            /*    var CatagoryFromDbFirst = _db.Catagories.FirstOrDefault(u => u.Id == id);
                var CatagoryFromDbSingle = _db.Catagories.SingleOrDefault(u => u.Id == id);*/

            if (CatagoryFromDb == null)
            {
                return (NotFound());
            }

            return View(CatagoryFromDb);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]


        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Catagories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Catagories.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}



