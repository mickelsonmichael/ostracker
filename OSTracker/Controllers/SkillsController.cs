using OSTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OSTracker.Controllers
{
    public class SkillsController : Controller
    {
        [RequireHttps]
        public ActionResult Index()
        {
            return View(SkillsHelper.GetSkills("rens0n"));
            // TODO: Return the skills of the logged in user or redirect to a join page
        }

        public ActionResult Lookup(string username)
        {
            return View();
        }

        public PartialViewResult GetSkills(string username)
        {
            return PartialView(SkillsHelper.GetSkills(username));
        }
    }
}