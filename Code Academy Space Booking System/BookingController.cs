using System;
using Microsoft.AspNetCore.Mvc;
namespace Code_Academy_Space_Booking_System
{
	public class BookingController:ControllerBase 
	{
        private readonly BookingDbContext _dbContext;

        public BookingController(BookingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var availableSpaces = _dbContext.Spaces.Where(s => !s.Bookings.Any()).ToList();
            return View(availableSpaces);
        }

        public IActionResult BookingDetails(int spaceId)
        {
            var bookingsForSpace = _dbContext.Bookings
                .Where(b => b.SpaceId == spaceId)
                .ToList();
            return View(bookingsForSpace);
        }

    }
}

