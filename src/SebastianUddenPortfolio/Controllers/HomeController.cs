using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SebastianUddenPortfolio.ViewModels;
using SebastianUddenPortfolio.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SebastianUddenPortfolio.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
            //return RedirectToAction("Home", "Portfolio");
        }

        [HttpPost]
        public IActionResult SendAnEmail(MailSenderVM mailSenderVMThing) // Lägg in en VM för det!
        {
            MailSender mail = new MailSender();
            mail.SendMail(mailSenderVMThing.Name, mailSenderVMThing.Subject, mailSenderVMThing.Email, mailSenderVMThing.Message); //From, Subject, Email, Text
            ViewData["mail_succes"] = "1";
            return RedirectToAction(nameof(HomeController.Index));
        }
    }
}
