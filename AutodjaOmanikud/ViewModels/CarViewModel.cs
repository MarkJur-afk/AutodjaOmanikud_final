using System.ComponentModel.DataAnnotations;

namespace AutodjaOmanikud.ViewModels
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string RegistrationNumber { get; set; } = string.Empty;
        public string OwnerName { get; set; } = string.Empty;
        public int OwnerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ServiceCount { get; set; }
        public decimal TotalSpent { get; set; }
    }

    public class CreateCarViewModel
    {
        [Required(ErrorMessage = "Марка обязательна")]
        [StringLength(50, ErrorMessage = "Максимум 50 символов")]
        public string Brand { get; set; } = string.Empty;

        [Required(ErrorMessage = "Модель обязательна")]
        [StringLength(50, ErrorMessage = "Максимум 50 символов")]
        public string Model { get; set; } = string.Empty;

        [Required(ErrorMessage = "Регистрационный номер обязателен")]
        [StringLength(20, ErrorMessage = "Максимум 20 символов")]
        public string RegistrationNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Владелец обязателен")]
        public int OwnerId { get; set; }
    }

    public class UpdateCarViewModel : CreateCarViewModel
    {
        public int Id { get; set; }
    }
}