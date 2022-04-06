using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartphoneApp.Models
{
    public class Guest 
    {
        public Guest(int guestID, string firstname, string lastname, DateTime birthdate, string language, string email)
        {
            GuestID = guestID;
            Firstname = firstname;
            Lastname = lastname;
            Birthdate = birthdate;
            Language = language;
            Email = email;
        }

        public int GuestID { get; set; } = 0;
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public String Language { get; set; }
        public String Email { get; set; }

    }
}
