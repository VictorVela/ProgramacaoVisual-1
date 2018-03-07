using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class PessoasController : Controller
    {

        private static IList<Pessoa> pessoaList = new List<Pessoa>
        {
            new Pessoa { Id = 1, Nome = "Joao" },
            new Pessoa { Id = 2, Nome = "Juan" },
            new Pessoa { Id = 3, Nome = "Jhon" }
        };

        public IActionResult Index()
        {
            var viewModel = new PessoaViewModel
            {
                Items = pessoaList
            };

            return View(viewModel);
        }
    }
}