using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Models;

namespace ProjectManagement.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            DatabaseContext context = new DatabaseContext();
            var student = context.Students.Where(x => x.FirstName == "John").FirstOrDefault();
            return View(student) ;
        }
    }
}