using BeautySalon.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace BeautySalon.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Името на категорията е задължително.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Името трябва да е между 3 и 50 символа.")]
        public string Name { get; set; } = null!;

        public ICollection<Service> Services { get; set; } = new List<Service>();
    }
}