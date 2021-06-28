using Microsoft.AspNetCore.Mvc;
using MVC_3_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_3_1.Controllers
{
    public class HomeController : Controller
    {
        JaluziContext db;
        public HomeController(JaluziContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Jaluzis.ToList());
        }
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.JaluziId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            //Сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо, " + order.Userr + ", за покупку! В ближайшее время c Вами свяжутся. ";
            

        }
        public IActionResult Order()
        {
            return View(db.Orders.ToList());
        }
    }
}
