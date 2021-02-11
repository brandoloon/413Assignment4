using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Suggestion
    {
        [Required(ErrorMessage = "Please provide your name")]
        public string Name { get; set; } // The name of the person submitting
        [Required(ErrorMessage = "Please enter a restaurant")]
        public string Restaurant { get; set; } // The suggested restaurant
        public string FavoriteDish { get; set; } = "It's all tasty!"; // The favorite dish of the individual submitting
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; } // The restaurant's phone number
    }
}
