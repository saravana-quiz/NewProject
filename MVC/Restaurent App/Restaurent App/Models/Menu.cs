using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurent_App.Models
{
    public class Menu
    {
        [Key]
        public int DishId { get; set; }
        [Required(ErrorMessage = "Dish Name is Required")]
        public string DishName { get; set; }
        [Required(ErrorMessage = "Enter Category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Price is a Required Feild")]
        public double Price { get; set; }
        [Display(Name = "In Stock")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "Image is a Required")]
        public string Image { get; set; }
    }
}