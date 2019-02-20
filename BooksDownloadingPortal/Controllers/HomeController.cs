using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BooksDownloadingPortal.Models;

namespace BooksDownloadingPortal.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			if (User.IsInRole("Admin"))
				return View("Admin");
			
				return View("Index");
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		[HttpGet]
		public FileResult downloadDracula()
		{
			return File("~\\file\\Dracula_NT.pdf","application/pdf", "Dracula.pdf");
		}

		[HttpGet]
		public FileResult downloadChristmasCarol()
		{
			return File("~\\file\\A_Christmas_Carol_NT.pdf", "application/pdf", "A Christmas Carol.pdf");
		}

		[HttpGet]
		public FileResult downloadalice()
		{
			return File("~\\file\\Alices_Adventures_in_Wonderland_NT.pdf", "application/pdf", "Alice's Adventure In WonderLand.pdf");
		}

		[HttpGet]
		public FileResult downloadaroundtheworld()
		{
			return File("~\\file\\Around_the_World_in_80_Days_NT.pdf", "application/pdf", "Around The World In 80 Days.pdf");
		}

		[HttpGet]
		public FileResult downloadCrime()
		{
			return File("~\\file\\Crime_and_Punishment_NT.pdf", "application/pdf", "Crime And Punishment.pdf");
		}

		[HttpGet]
		public FileResult downloadBeyondGood()
		{
			return File("~\\file\\Beyond_Good_and_Evil_NT.pdf", "application/pdf", "Beyond Good And Evil.pdf");
		}

		[HttpGet]
		public FileResult downloadFairyTales()
		{
			return File("~\\file\\Andersens_Fairy_Tales_NT.pdf", "application/pdf", "Andersen's Fairy Tales.pdf");
		}

		[HttpGet]
		public FileResult downloadTaleOfTwoCities()
		{
			return File("~\\file\\A_Tale_of_Two_Cities_NT.pdf", "application/pdf", "A Tale Of Two Cities.pdf");
		}
	}
}