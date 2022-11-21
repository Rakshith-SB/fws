using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public string Address { get; set; }

        public string Location { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }

    }
}
