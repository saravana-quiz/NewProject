using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bank_Customer.Models
{
    public class CustomerDetails
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(25, ErrorMessage = "Name can not exceed 25 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address can not exceed 1000 characters")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }
        [Range(500,10000000,ErrorMessage ="Minimum Balance 500")]
        [DisplayName("Opening Balane")]
        public int OpeningBalance { get; set; }

    }
}
