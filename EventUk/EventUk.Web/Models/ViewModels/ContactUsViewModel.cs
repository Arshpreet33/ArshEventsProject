using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventUk.Web.Models.ViewModels
{
    public class ContactUsViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}