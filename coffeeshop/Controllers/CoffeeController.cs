using coffeeshop.Data;
using coffeeshop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace coffeeshop.Controllers
{
    public class CoffeeController : Controller
    {
      
        private readonly ApplicationDbContext _db;

        public CoffeeController(ApplicationDbContext db)
        {
           
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<coffeeList> getcoffeelist = _db.coffeetbl;
            return View(getcoffeelist);
        }


        //------------------ Edit -----------------------------
        public IActionResult Edit(int? Cid)
        {
            if (Cid == null || Cid == 0)
            {
                return NotFound();
            }
            var coffeeFromDb = _db.coffeetbl.Find(Cid); 

            //if id not found
            if (coffeeFromDb == null)
            {
                return NotFound();
            }
            return View(coffeeFromDb);
        }

        //POST

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(coffeeList obj)
        {
            /*
            if (obj.account_name == obj.password.ToString())
            {
                //show in summary
                ModelState.AddModelError("acc_error", "Name And Password is Same!!");
            }*/
            if (ModelState.IsValid) //validation
            {
                _db.coffeetbl.Update(obj); //like Update query
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
    }
}
