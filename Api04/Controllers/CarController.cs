using Api04.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Api04.Models;

namespace Api04.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {

        private readonly ILogger<CarController> _logger;
        private readonly ICarRepository _carRepository;

        public CarController(ILogger<CarController> logger, ICarRepository carRepository)
        {
            _logger = logger;
            _carRepository = carRepository;
        }

        [HttpGet(Name = "GetCars")]
        public IEnumerable<Car> Get()
        {
            return _carRepository.Get();
        }
        
        [HttpPost(Name = "NewCar")]
        public void AddNewCarr(string manufacturer, string model, string color, int year)
        {
            Car car = new Car(manufacturer, model, color, year);
            _carRepository.AddNewCar(car);
            
        }
    }
}