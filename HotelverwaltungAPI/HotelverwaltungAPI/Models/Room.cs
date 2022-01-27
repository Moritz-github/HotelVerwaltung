using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelverwaltungAPI.Models
{
    public class Room
    {
        public Room(int roomId, int countBeds, bool hasKitchen, bool hasBalcony, bool hasTerrac, decimal nightlyPrice)
        {
            RoomId = roomId;
            CountBeds = countBeds;
            HasKitchen = hasKitchen;
            HasBalcony = hasBalcony;
            HasTerrac = hasTerrac;
            NightlyPrice = nightlyPrice;
        }

        public int RoomId { get; set; }
        public int CountBeds { get; set; }
        public bool HasKitchen { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasTerrac { get; set; }
        public decimal NightlyPrice { get; set; }
        public ICollection<Bill> Bills { get; set; }
        public List<RoomBill> RoomBill { get; set; }
    }
}
