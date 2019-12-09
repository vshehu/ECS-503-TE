using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Models;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            DatabaseContext context = new DatabaseContext();

            var students = from s in context.Students
                           where s.LastName == "Doe"
                           select new
                           {
                               FirstName = s.FirstName,
                               LastName = s.LastName,
                               Birthdate = s.Birthdate
                           };
            foreach (var s in students)
            {
                Console.WriteLine("Firstname: " + s.FirstName);
                Console.WriteLine("Lastname: " + s.LastName);
                Console.WriteLine("Birthdate: " + s.Birthdate);
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
