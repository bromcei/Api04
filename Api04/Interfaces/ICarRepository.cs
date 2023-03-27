using Api04.Models;
using System.Collections.Generic;

namespace Api04.Interfaces
{
    public interface ICarRepository
    {
        public IEnumerable<Car> Get();
        public void AddNewCar(Car car);
    }
}
