using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proView.Controllers
{
    public class WorkController : Controller
    {
        // GET: Work
        public ActionResult Index()
        {
            return View();
        }

		[HttpGet]
		public ActionResult Detail()
		{
			ViewBag.Message = "Your app description page.";

			return View();
		}

		[HttpGet]
		public ActionResult Board()
		{
			ViewBag.Message = "Bulletin Board.";

			return View();
		}


		[HttpGet]
		public ActionResult Admin()
		{
			ViewBag.Message = "Board Management";

			return View();
		}

		[HttpGet]
		public ActionResult Menu()
		{
			ViewBag.Message = "Menu Management";

			return View();
		}


		[HttpGet]
		public ActionResult Social()
		{
			ViewBag.Message = "Connect Socal medias.";

			return View();
		}
	}
}