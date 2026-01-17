using AutodjaOmanikud.Models;
using AutodjaOmanikud.ViewModels;

namespace AutodjaOmanikud.Interfaces
{
    public interface ICarService
    {
        Task<IEnumerable<CarViewModel>> GetAllCarsAsync();
        Task<CarViewModel?> GetCarByIdAsync(int id);
        Task<Car> CreateCarAsync(CreateCarViewModel model);
        Task UpdateCarAsync(int id, UpdateCarViewModel model);
        Task DeleteCarAsync(int id);
        Task<IEnumerable<CarViewModel>> GetCarsByOwnerAsync(int ownerId);
        Task<bool> IsRegistrationNumberUniqueAsync(string regNumber, int? excludeId = null);
    }
}