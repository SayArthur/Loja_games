using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Loja_games.Models;
using System.Collections.ObjectModel;

namespace Loja_games.Controllers
{
    public class JogoController : Controller
    {

        public ActionResult Index()
        {
            var game  = new Model_Jogo();
            return View(game);
        }

        [HttpPost]
        public ActionResult Index(Model_Jogo game)
        {
            if (ModelState.IsValid)
            {
                return View("Listar_Jogo", game);
            }
            return View(game);
        }

        public ActionResult Listar_Jogo(Model_Jogo game)
        {
            return View(game);
        }

    }
}