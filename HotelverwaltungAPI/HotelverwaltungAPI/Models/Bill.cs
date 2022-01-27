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
            this.payed = payed;
            this.paymentTarget = paymentTarget;
            this.paymentMethod = paymentMethod;
        }

        public int BillID { get; set; }
        public int GuestID { get; set; }
        public bool payed { get; set; }
        public DateTime paymentTarget { get; set; }
        public String paymentMethod { get; set; }


    }
}
