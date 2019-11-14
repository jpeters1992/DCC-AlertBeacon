using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALERTBEACON.Models
{
    public class Observer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "License Plate #")]
        public string LicensePlate { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Reward")]
        public string Reward { get; set; }

       
        [Display(Name = "Car Issues")]
        public string CarIssue { get; set; }

        public IEnumerable<SelectListItem> Issues { get; set; }

    }
    

}