using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace coffeeshop.Models
{
    public class coffeeList
    {
        [Key]
        public int coffeeId { get; set; }

        [Required]
        [DisplayName("Name")]
        public string coffeeName { get; set;}

        [Required]
        [DisplayName("Quantity")]
        public int quantity { get; set; }




    }
}
