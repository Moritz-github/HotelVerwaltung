using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelverwaltungAPI.Models
{
    public class Bill
    {
        public Bill(int billID, int guestID, bool payed, DateTime paymentTarget, string paymentMethod)
        {
            BillID = billID;
            GuestID = guestID;
            this.Payed = payed;
            this.PaymentTarget = paymentTarget;
            this.PaymentMethod = paymentMethod;
        }

        public int BillID { get; set; }
        public int GuestID { get; set; }
        public bool Payed { get; set; }
        public DateTime PaymentTarget { get; set; }
        public String PaymentMethod { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public List<RoomBill> RoomBill { get; set; }

    }
}
