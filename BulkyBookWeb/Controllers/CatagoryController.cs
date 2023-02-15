using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
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
    }
}
