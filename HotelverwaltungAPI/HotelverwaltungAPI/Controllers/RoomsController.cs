using HotelverwaltungAPI.Models;
using HotelverwaltungAPI.Models.db;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            return this._context.RoomsBills.Where(rb => rb.StartDate > startDateTime && rb.EndDate < endDateTime).Select(rb => rb.Room).ToList();
        }
    }
}
