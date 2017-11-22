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
            //return our GetAll method so that it will pass the entire list to be displayed.
            return View(Character.GetAll());
        }

        public ActionResult Create(string characterName)
        {
            Character.Create(characterName);
            var model = new Character();
            model.Name = characterName;
            //instead of returning the view we'll redirect to the action in our home controller.
            //This keeps the user from creating a character twice by refreshing, avoiding duplicate code
            return RedirectToAction("Index");
        }
    }
}