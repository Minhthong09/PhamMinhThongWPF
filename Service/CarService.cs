using BusinessObject.Models;
using Reposioties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CarService : ICarService
    {
        private ICarRepository carRepository;

        public CarService()
        {
            carRepository = new CarRepository();
        }

        public List<CarInformation> GetAll()
        {
            return carRepository.GetAll();
        }
    }
}
