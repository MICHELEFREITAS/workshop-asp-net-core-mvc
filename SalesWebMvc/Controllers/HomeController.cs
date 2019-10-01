using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;

namespace SalesWebMvc.Controllers
{
    public class HomeController : Controller
    {
        //tipo de retorno de todas ações: IActionResult (interface, tipo genérico para todo result ação). Interface do ViewResult
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            //ViewData dicionário c# coleção pares chave e valor
            ViewData["Message"] = "Salles web MVC App from C#";
            ViewData["autor"] = "Michele Freitas";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
