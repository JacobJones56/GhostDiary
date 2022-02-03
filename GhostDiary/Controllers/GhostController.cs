using GhostDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GhostDiary.Controllers
{
    public class GhostController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(GhostCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

        }





    }
}