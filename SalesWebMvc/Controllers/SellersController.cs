using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers
{
    //recebe a chamada do caminho /Sellers quando clica no link da pág
    public class SellersController : Controller
    {
        //aciona view que está na pasta Sellers com nome index. O controlador encaminhou requisição para view. Assim é o MVC
        public IActionResult Index()
        {
            return View();
        }
    }
}