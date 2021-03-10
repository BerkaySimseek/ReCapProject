using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal:ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,ColorId = 1,DailyPrice = 150,Description = "Peugot 206", ModelYear = 2006},
                new Car{Id = 2,ColorId = 1,DailyPrice = 140,Description = "Peugot 205", ModelYear = 2005},
                new Car{Id = 3,ColorId = 2,DailyPrice = 130,Description = "Peugot 204", ModelYear = 2004},
                new Car{Id = 4,ColorId = 2,DailyPrice = 180,Description = "Peugot 208", ModelYear = 2008}
            };
        }


        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public Car GetById(int id)
        {
            Car carToGetById = _cars.SingleOrDefault(c => c.Id == id);
            
            return carToGetById;
        }
    }
}
