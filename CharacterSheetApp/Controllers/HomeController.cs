using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CharacterSheetApp.Models;

namespace CharacterSheetApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(string characterName)
        {
            var model = new CharacterSheetApp.Models.Home();
            model.Name = characterName;
            return View("Index", model);
        }
    }
}