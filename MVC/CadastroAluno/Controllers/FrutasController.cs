using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CadastroAluno.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CadastroAluno.Controllers
{

    public class FrutasController : Controller
    {

        private readonly ILogger<FrutasController> _logger;

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }


        // Criar uma lista de frutas
        private static List<Fruta> frutas = new List<Fruta>
{
    new Fruta{Id = 1, Nome = "Maca", Cor = "Vermelho", Categoria = "Tropical"},
    new Fruta{Id = 2, Nome = "Banana", Cor = "Amarelo", Categoria = "Tropical"},
    new Fruta{Id = 3, Nome = "Uva", Cor = "Roxo", Categoria = "Tropical"},
    new Fruta{Id = 4, Nome = "Limao", Cor = "Verde", Categoria = "Citrico"},
    new Fruta{Id = 5, Nome = "Abacaxi", Cor = "Amarelo", Categoria = "Citrico"},


};

        public IActionResult Index()
        {
            return View(frutas);
        }
           [HttpPost]

           
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(Fruta fruta)
        {
            fruta.Id = frutas.Max(f => f.Id) + 1;

            frutas.Add(fruta);

            return RedirectToAction("Index");
        }
        public IActionResult FrutasCitricas()
        {
            return View(frutas);
        }
     
        public IActionResult FrutasTropicais()
        {
            return View(frutas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}