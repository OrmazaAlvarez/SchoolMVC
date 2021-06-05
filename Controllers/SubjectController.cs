using System;
using Microsoft.AspNetCore.Mvc;
using SchoolMVC.Models;

namespace SchoolMVC.Controllers
{
    public class SubjectController: Controller
    {
        public IActionResult Index(){
            var subject = new Subject{
                Name = "Programming",
                UniqueId = Guid.NewGuid().ToString()
            };
            ViewBag.DynamicThing = "The Nun";
            return View(subject);
        }
    }
}