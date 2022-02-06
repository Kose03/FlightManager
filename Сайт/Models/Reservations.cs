using FlightManager.Areas.Identity.Data;

namespace FlightManager.Areas.Identity.Data
{
    public class Reservations
    {
        public virtual ApplicationUser User { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string FathersName { get; set; }
        public string FamilyName { get; set; }
        public int EGN { get; set; }
        public int TelephoneNumber { get; set; }
        public string Nationality { get; set; }
        public string TypeOfTicket { get; set; }
    }
}
