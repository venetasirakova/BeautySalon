using System.ComponentModel.DataAnnotations;

namespace BeautySalon.Data.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Името на клиента е задължително.")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Името трябва да е между 2 и 60 символа.")]
        public string ClientName { get; set; } = null!;

        [Required(ErrorMessage = "Телефонният номер е задължителен.")]
        [Phone(ErrorMessage = "Моля, въведете валиден телефонен номер.")]
        public string ClientPhone { get; set; } = null!;

        [Required(ErrorMessage = "Датата и часът са задължителни.")]
        public DateTime DateTime { get; set; }

        public int ServiceId { get; set; }
        public Service? Service { get; set; }

        public string Status { get; set; } = "Confirmed";
    }
}