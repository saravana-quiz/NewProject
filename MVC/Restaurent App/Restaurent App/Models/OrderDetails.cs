using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurent_App.Models
{
    public class OrderDetails
    {
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Phone Number is Required")]
        [Phone(ErrorMessage = "Enter the valid Phone Number")]
        public double PhoneNumber { get; set; }
    }
}