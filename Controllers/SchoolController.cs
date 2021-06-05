using System;
using Microsoft.AspNetCore.Mvc;
using SchoolMVC.Models;

namespace SchoolMVC.Controllers
{
    public class SchoolController: Controller
    {
        public IActionResult Index(){
            var school = new School();
            school.Name = "Platzi School";
            school.CreationYear = 2005;
            school.UniqueId = Guid.NewGuid().ToString();
            school.Country = "Ecuador";
            school.City = "El Empalme";
            school.Address = "Via Quevedo";
            school.SchoolType = SchoolType.Secondary;
            return View(school);
        }
    }
}