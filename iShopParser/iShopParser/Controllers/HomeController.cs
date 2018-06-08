using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using iShopParser.Models;
using iShopParser.Services;

namespace iShopParser.Controllers
{
    public class HomeController : Controller
    {
        
        
        ParserService service = new ParserService ();
            
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            
            
            var res = service.ListTitles;      

            ViewData["Message"] = "";


            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
