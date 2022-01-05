using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class Reservations
    {
        public int Id { get; set; }      
        public string FirstName { get; set; }      
        public string FathersName { get; set; }      
        public string FamilyName { get; set; }    
        public int EGN { get; set; }
        public int TelephoneNumber { get; set; }
        public string Nationality { get; set; }
        public string TypeOfTicket { get; set; }

        public Reservations()
        {
                
        }
    }
}
