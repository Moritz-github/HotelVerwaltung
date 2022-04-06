using HotelverwaltungAPI.Models;
using HotelverwaltungAPI.Models.db;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelverwaltungAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private DbContextHotel _context = new DbContextHotel();

        [HttpGet]
        public List<Guest> getAllGuestsFromDb()
        {
            return this._context.Guests.ToList();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult addGuest(Guest g)
        {
                this._context.Guests.Add(g);
                this._context.SaveChanges();
            return Ok();
        }
    }
}
