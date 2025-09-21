using System.ComponentModel.DataAnnotations;

namespace MiEcommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; } = "";
        
        public string Description { get; set; } = "";
        
        [Required]
        public decimal Price { get; set; }
        
        [Required]
        public int Stock { get; set; }
        
        public string Category { get; set; } = "";
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}