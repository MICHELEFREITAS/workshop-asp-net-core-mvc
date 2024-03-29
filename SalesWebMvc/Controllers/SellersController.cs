﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    //recebe a chamada do caminho /Sellers quando clica no link da pág
    public class SellersController : Controller
    {
        //dependencia para o SellerService
        private readonly SellerService _sellerService;

        //construtor para injetar depend.
        public SellersController(SellerService sellerService) {
            _sellerService = sellerService;
        }

        //aciona view que está na pasta Sellers com nome index. O controlador encaminhou requisição para view. Assim é o MVC
        //MVC 1º*chama controlador
        public IActionResult Index()
        {
            //retorna lista seller. 2º*Controlador acessa Model e pega dado na lista
            var list = _sellerService.FindAll();
            //3º* Encaminha dados para View
            return View(list);
        }

        //Ação botão Create New. Retorna View create. Depois Views-Sellers-Create.cshtml
        public IActionResult Create()
        {
            return View();
        }

        //"Create" Post action. Recebe obj vendedor que veio na requisição. INSERIR NO BD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller) {
            _sellerService.Insert(seller);
            //redirecionar
            return RedirectToAction(nameof(Index));
        }



    }
}