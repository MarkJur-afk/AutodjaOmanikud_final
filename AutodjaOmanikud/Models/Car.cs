using System.ComponentModel.DataAnnotations;
using AutodjaOmanikud.Constants;

namespace AutodjaOmanikud.Models
{
    public class Car
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Марка обязательна")]
        [StringLength(50, ErrorMessage = "Максимум 50 символов")]
        public string Brand { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Модель обязательна")]
        [StringLength(50, ErrorMessage = "Максимум 50 символов")]
        public string Model { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Регистрационный номер обязателен")]
        [StringLength(AppConstants.Validation.MaxRegNumberLength, ErrorMessage = "Максимум {1} символов")]
        public string RegistrationNumber { get; set; } = string.Empty;
        
        public int? Year { get; set; }
        public string? Color { get; set; }
        public string? VIN { get; set; }
        public int? Mileage { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;
        
        public int OwnerId { get; set; }
        public virtual Owner Owner { get; set; } = null!;
        public virtual ICollection<Service> Services { get; set; } = new List<Service>();
        
        public int ServiceCount => Services?.Count ?? 0;
        public decimal TotalSpent => Services?.Sum(s => s.ServiceType?.Price ?? 0) ?? 0;
        public DateTime? LastServiceDate => Services?.Max(s => s.Time);
    }
}