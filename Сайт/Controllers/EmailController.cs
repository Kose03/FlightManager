using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FlightManager.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailSender _emailSender;

        public EmailController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public async Task TestAction()
        {
            await _emailSender.SendEmailAsync("flightmanager2021@gmail.com", "Registration",
                         $"Enter email body here");
        }
    }
}
