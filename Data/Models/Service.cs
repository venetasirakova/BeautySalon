using BeautySalon.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautySalon.Data.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Името на услугата е задължително.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Името трябва да е между 3 и 100 символа.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Описанието е задължително.")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Описанието трябва да е поне 10 символа.")]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "Цената е задължителна.")]
        [Range(0.01, 1000.00, ErrorMessage = "Цената трябва да е между 0.01 и 1000.00 лв.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Времетраенето е задължително.")]
        [Range(5, 480, ErrorMessage = "Времетраенето трябва да е между 5 и 480 минути.")]
        public int DurationInMinutes { get; set; }

        [Display(Name = "Категория")]
        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}