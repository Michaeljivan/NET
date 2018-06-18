using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System;
using System.Linq;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // Returns a view page
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon/Evening";
            return View("Index");
        }

        [HttpGet]
        public ViewResult RsvpForm() {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse){
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                // validation error
                return View();
            }

        }

        public ViewResult ListResponses() {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }

        [HttpGet]
        public ViewResult Rent() {
            return View("Rent");
        }
        
    }
}