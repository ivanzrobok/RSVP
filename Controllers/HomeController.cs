using Microsoft.AspNetCore.Mvc;
using System;
using WebAppMvc.Models;
using System.Linq;

namespace WebAppMvc.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        public ViewResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Goot Morning" : "Goot Afternoon";
            return View("MyView");
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)//показує чи пройшли в моделі атрибути Required
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }

    }
}
