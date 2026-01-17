using AutodjaOmanikud.Data;
using AutodjaOmanikud.Interfaces;
using AutodjaOmanikud.Models;
using AutodjaOmanikud.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace AutodjaOmanikud.Services
{
    public class CarService : ICarService
    {
        private readonly AutoDbContext _context;
        private readonly IRepository<Car> _carRepository;

        public CarService(AutoDbContext context, IRepository<Car> carRepository)
        {
            _context = context;
            _carRepository = carRepository;
        }

        public async Task<IEnumerable<CarViewModel>> GetAllCarsAsync()
        {
            var cars = await _context.Cars
                .Include(c => c.Owner)
                .Include(c => c.Services)
                .ThenInclude(s => s.ServiceType)
                .Select(c => new CarViewModel
                {
                    Id = c.Id,
                    Brand = c.Brand,
                    Model = c.Model,
                    RegistrationNumber = c.RegistrationNumber,
                    OwnerName = c.Owner.FullName,
                    OwnerId = c.OwnerId,
                    ServiceCount = c.Services.Count,
                    TotalSpent = c.Services.Sum(s => s.ServiceType.Price)
                })
                .ToListAsync();

            return cars;
        }

        public async Task<CarViewModel?> GetCarByIdAsync(int id)
        {
            var car = await _context.Cars
                .Include(c => c.Owner)
                .Include(c => c.Services)
                .ThenInclude(s => s.ServiceType)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (car == null) return null;

            return new CarViewModel
            {
                Id = car.Id,
                Brand = car.Brand,
                Model = car.Model,
                RegistrationNumber = car.RegistrationNumber,
                OwnerName = car.Owner.FullName,
                OwnerId = car.OwnerId,
                ServiceCount = car.Services.Count,
                TotalSpent = car.Services.Sum(s => s.ServiceType.Price)
            };
        }

        public async Task<Car> CreateCarAsync(CreateCarViewModel model)
        {
            if (await IsRegistrationNumberUniqueAsync(model.RegistrationNumber) == false)
                throw new InvalidOperationException("Регистрационный номер уже существует");

            var car = new Car
            {
                Brand = model.Brand,
                Model = model.Model,
                RegistrationNumber = model.RegistrationNumber,
                OwnerId = model.OwnerId
            };

            await _carRepository.AddAsync(car);
            await _carRepository.SaveChangesAsync();
            return car;
        }

        public async Task UpdateCarAsync(int id, UpdateCarViewModel model)
        {
            var car = await _carRepository.GetByIdAsync(id);
            if (car == null)
                throw new ArgumentException("Автомобиль не найден");

            if (await IsRegistrationNumberUniqueAsync(model.RegistrationNumber, id) == false)
                throw new InvalidOperationException("Регистрационный номер уже существует");

            car.Brand = model.Brand;
            car.Model = model.Model;
            car.RegistrationNumber = model.RegistrationNumber;
            car.OwnerId = model.OwnerId;

            await _carRepository.UpdateAsync(car);
            await _carRepository.SaveChangesAsync();
        }

        public async Task DeleteCarAsync(int id)
        {
            await _carRepository.DeleteAsync(id);
            await _carRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<CarViewModel>> GetCarsByOwnerAsync(int ownerId)
        {
            var cars = await _context.Cars
                .Include(c => c.Owner)
                .Include(c => c.Services)
                .ThenInclude(s => s.ServiceType)
                .Where(c => c.OwnerId == ownerId)
                .Select(c => new CarViewModel
                {
                    Id = c.Id,
                    Brand = c.Brand,
                    Model = c.Model,
                    RegistrationNumber = c.RegistrationNumber,
                    OwnerName = c.Owner.FullName,
                    OwnerId = c.OwnerId,
                    ServiceCount = c.Services.Count,
                    TotalSpent = c.Services.Sum(s => s.ServiceType.Price)
                })
                .ToListAsync();

            return cars;
        }

        public async Task<bool> IsRegistrationNumberUniqueAsync(string regNumber, int? excludeId = null)
        {
            var query = _context.Cars.Where(c => c.RegistrationNumber == regNumber);
            
            if (excludeId.HasValue)
                query = query.Where(c => c.Id != excludeId.Value);

            return !await query.AnyAsync();
        }
    }
}