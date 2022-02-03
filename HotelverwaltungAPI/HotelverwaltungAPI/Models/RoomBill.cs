using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelverwaltungAPI.Models
{
    public class RoomBill
    {
        public int RoomDiscount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }

        public int BillId { get; set; }
        public Bill Bill { get; set; }
    }
}
