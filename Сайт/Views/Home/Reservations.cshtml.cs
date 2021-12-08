using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static AuthSystem.Areas.Identity.Pages.Account.RegisterModel;

namespace FlightManager.Areas.Identity.Pages
{
    public class ReservationsModel : PageModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "���")]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "������ ���")]
        public string FathersName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "������� ���")]
        public string FamilyName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "���")]
        public string EGN { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "����� �����")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "��������� �����")]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "������������")]
        public string Nationality { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "��� �� ������")]
        public string TypeOfTicket { get; set; }

        public InputModel Input { get; set; }

       
        public string ReturnUrl { get; set; }
        public void OnGet()
        {
        }
    }
}
