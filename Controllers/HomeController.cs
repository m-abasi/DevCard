using DevCard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
            new Service(1, "نقره ای"),
            new Service(2, "طلائی"),
            new Service(3, "پلاتین"),
            new Service(4, "الماس"),
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProjectDetails(long id)
        {
            var projects = ProjectData.GetProjectById(id);
            return View(projects);
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            return View(model);
        }


        ///////////////////////////////--------IFormCollection---------\\\\\\\\\\\\\\\\\\\\\


        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    string name = form["name"];
        //    return Json(Ok());
        //}


        ///////////////////////////////--------Model Binding---------\\\\\\\\\\\\\\\\\\\\\
        /// 
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_services, "Id", "Name");

            if (!ModelState.IsValid)
            {
                ViewBag.error = "لطفا دوباره تلاش کنید - عملیات با خطا مواجه شد";
                return View(model);
            }

            ModelState.Clear();

            model = new Contact()
            {
                Services = new SelectList(_services, "Id", "Name")
            };

            ViewBag.success = "عملیات با موفقیت انجام شد";
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}