using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MVCFilmes.Controllers
{
    //[Route("[controller]")]
    public class FilmesController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BemVindo(string nome, int id)
        {
            ViewData["Title"] = "Bem vindos";

            ViewData["Nome"] = nome;
            ViewData["Nimerox"] = id;

            return View();
        }
    }
}