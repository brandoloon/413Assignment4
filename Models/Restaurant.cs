using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Restaurant
    {
        public Restaurant(int rank)
        {
            Rank = rank;
        }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Rank { get; }
        public string? FavoriteDish { get; set; } = "It's all tasty!";
        [Required]
        public string Address { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter a valid phone number")]
        public string? Phone { get; set; }
        public string? Link { get; set; } = "Coming soon.";

        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                Name = "K's Kitchen",
                FavoriteDish = "Katsu Don",
                Address = "322 W Center St, Provo, UT 84601",
                Phone = "385-201-7523",
                Link = "https://www.ksjapanesekitchen.com"
            };
            Restaurant r2 = new Restaurant(2)
            {
                Name = "Bombay House",
                FavoriteDish = "Chicken Tikka Masala",
                Address = "463 N University Ave, Provo, UT 84601",
                Phone = "801-373-6677",
                Link = "https://www.bombayhouse.com"
            };
            Restaurant r3 = new Restaurant(3)
            {
                Name = "Cubby's",
                Address = "1258 N State St, Provo, UT 84604",
                Phone = "801-919-3023"
            };
            Restaurant r4 = new Restaurant(4)
            {
                Name = "Chick-fil-A",
                Address = "BYU Cougareat"
            };
            Restaurant r5 = new Restaurant(5)
            {
                Name = "Black Bear Diner",
                Address = "771 E University Pkwy, Orem, UT 84097",
                Phone = "385-236-2782",
                Link = "https://blackbeardiner.com/location/orem/"
            };
            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
