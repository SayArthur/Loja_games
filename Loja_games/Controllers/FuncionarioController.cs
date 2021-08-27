using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Loja_games.Models;
using System.Collections.ObjectModel;

namespace Loja_games.Controllers
{
    public class FuncionarioController : Controller
    {

        public ActionResult Index()
        {
            var func = new Model_Func();
            return View(func);
        }

        [HttpPost]
        public ActionResult Index(Model_Func func)
        {

            if (ModelState.IsValid)
            {
                return View("Listar_Funcionario", func);
            }
            return View(func);
        }

        public ActionResult Listar_Funcionario(Model_Func func)
        {
            return View(func);
        }

    }
}