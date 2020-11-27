using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using SalesWebMVC.Models.ViewModels;

namespace SalesWebMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Sales Web MVC Application from C# Course";
            ViewData["author"] = "Marcely Biguzzi Santello";
            ViewData["text"] = "Primeiro sistema Web escrito em C# com Core MVC e Entity Framwork";
            ViewData["email"] = "marcely@sbsoftware.com.br";
            
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Some ways to talk to me :)";
            ViewData["author"] = "Marcely Biguzzi Santello";
            ViewData["linkedin"] = "www.linkedin.com";
 
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
