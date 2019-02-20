using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BooksDownloadingPortal.Controllers
{
	public class BookDetailsController : Controller
	{
		// GET: BookDetails
		public ActionResult Book1()
		{

			return View("Dracula");
		}

		public ActionResult Book2()
		{

			return View("ChristmasCarol");
		}

		public ActionResult Book3()
		{

			return View("alice");
		}
		public ActionResult Book4()
		{

			return View("aroundtheworld");
		}

		public ActionResult Book5()
		{

			return View("crime");
		}

		public ActionResult Book6()
		{

			return View("twocities");
		}

		public ActionResult Book7()
		{

			return View("fairytales");
		}
		public ActionResult Book8()
		{

			return View("beyondgood");
		}
	}
}