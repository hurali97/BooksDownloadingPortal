using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BooksDownloadingPortal.Models;

namespace BooksDownloadingPortal.Controllers
{
	public class SeatNumbersController : Controller
	{


		private ApplicationDbContext _context;

		public SeatNumbersController()
		{
			_context = new ApplicationDbContext();
		}

		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}


		// GET: SeatNumbers
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult NewSeatNumber()
		{
			var seat = new SeatNumbers();

			return View("NewSeatNumber",seat);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]

public ActionResult Save(SeatNumbers seatNumbers)
{
	var seatfromDb = _context.SeatNumbers.ToList();
	foreach (var seat in seatfromDb)
	{
		if (seatNumbers.SeatNumber.Equals(seat.SeatNumber))
		{
			return View("errorIndb");
		}
	}

			 
				if (seatNumbers.Id == 0)
				{  
					_context.SeatNumbers.Add(seatNumbers);
				}
				


				_context.SaveChanges();


				return RedirectToAction("NewSeatNumber", "SeatNumbers");
			}
	
	}
}