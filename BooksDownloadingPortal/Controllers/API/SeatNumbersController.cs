using BooksDownloadingPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BooksDownloadingPortal.Controllers.API
{
    public class SeatNumbersController : ApiController
    {
	    private ApplicationDbContext _context;

	    public SeatNumbersController()
	    {
			_context = new ApplicationDbContext();
		}

		[HttpPost]
	    public IHttpActionResult CreateCustomer(SeatNumbers seatNumbers)
	    {
		    if (!ModelState.IsValid)
		    {
			    return BadRequest();
		    }

		   
		     _context.SeatNumbers.Add(seatNumbers);
		    _context.SaveChanges();

		  //  customerdto.Id = customer.Id;

		    return Created(new Uri(Request.RequestUri + "/" +seatNumbers.Id),seatNumbers);
	    }
	}
}
