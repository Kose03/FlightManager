using FlightManager.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace FlightManager.Areas.Identity.Data
{
    public class Reservations
    {
        public virtual ApplicationUser User { get; set; }
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Първо име")]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Бащино име")]
        public string FathersName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Семейно име")]
        public string FamilyName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "ЕГН")]
        public int EGN { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Телефон за контакт")]
        public int TelephoneNumber { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Имейл адрес")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Националност")]
        public string Nationality { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Тип на билета")]
        public string TypeOfTicket { get; set; }
    }
}

