using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Loja_games.Models;
using System.Collections.ObjectModel;

namespace Loja_games.Controllers
{

    public class ClienteController : Controller
    {
        public ActionResult Index()
        {
            var cliente = new Model_Cliente();
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Index(Model_Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                return View("Listar_Cliente", cliente);
            }
            return View(cliente);
        }

        public ActionResult Listar_Cliente(Model_Cliente cliente)
        {
            return View(cliente);
        }

    } 
}