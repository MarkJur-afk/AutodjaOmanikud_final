using System.ComponentModel.DataAnnotations;
using AutodjaOmanikud.Constants;

namespace AutodjaOmanikud.Models
{
    public class Owner
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Имя владельца обязательно")]
        [StringLength(AppConstants.Validation.MaxStringLength, ErrorMessage = "Максимум {1} символов")]
        public string FullName { get; set; } = string.Empty;
        
        [StringLength(AppConstants.Validation.MaxPhoneLength, ErrorMessage = "Максимум {1} символов")]
        public string Phone { get; set; } = string.Empty;
        
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;
        
        public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
        public int CarsCount => Cars?.Count ?? 0;
        public decimal TotalSpent => Cars?.SelectMany(c => c.Services ?? new List<Service>())
            .Sum(s => s.ServiceType?.Price ?? 0) ?? 0;
    }
}