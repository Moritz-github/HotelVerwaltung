using HotelverwaltungAPI.Models;
using HotelverwaltungAPI.Models.db;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelverwaltungAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private DbContextHotel _context = new DbContextHotel();

        [HttpGet]
        public List<Room> getAllRoomsFromDb()
        {
            return this._context.Rooms.ToList();
        }

        [HttpPost]
        [Route("getFreeRooms")]
        public List<Room> getFreeRoomsFromDb(DateTime startDateTime, DateTime endDateTime)
        {
            var q = from g in this._context.Guests where g.Email.Length > 5 select g;
            List < Room > bookedRooms = this._context.RoomsBills.Where(rb =>
                 (rb.EndDate > startDateTime && rb.StartDate < startDateTime)
              || (rb.StartDate < endDateTime && rb.EndDate > endDateTime)
              || (rb.StartDate < startDateTime && rb.EndDate > endDateTime)).Select(rb => rb.Room).ToList();

            return this._context.Rooms.Where(room => !bookedRooms.Contains(room)).ToList();
        }


        [HttpGet]
        [Route("getBornAfter2000")]
        public List<Guest> getBornAfter2000()
        {
            var q = from g in _context.Guests where g.Birthdate.Year > 2000 select g;
            var q2 = _context.Guests.Where(guest => guest.Birthdate.Year > 2000);
            return q.ToList();
        }
    }
}
