using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelverwaltungAPI.Models.db
{
    public class DbContextHotel : DbContext
    {
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomBill> RoomsBills { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RoomBill>().HasKey(table => new {
                table.RoomId,
                table.BillId
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var server = "localhost";
            var database = "hotelverwaltung";
            var user = "root";
            var password = "----";
            optionsBuilder.UseMySQL($"Server={server};database={database};user={user};password={password}");
        }
    }
}
