using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SebastianUddenPortfolio.ViewModels
{
    public class MailSenderVM
    {
        [Display(Name = "Subject")]
        [Required(ErrorMessage = "Please enter a subject")]
        public string Subject { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter your Email")]
        public string Email { get; set; }

        [Display(Name = "Message")]
        [Required(ErrorMessage = "Please add some content to your message")]
        public string Message { get; set; }
    }
}
