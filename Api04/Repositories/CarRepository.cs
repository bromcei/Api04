using Api04.Interfaces;
using Api04.Models;

namespace Api04.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _context;
        public CarRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Car> Get()
        {
            return _context.Cars.ToList();
        }

        public void AddNewCar(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }
    }
}
