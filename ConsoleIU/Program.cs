using System;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            carManager.Add(new Car
            {
                ColorId = 1,DailyPrice = 100,Description = "Peugot 308",ModelYear = 2010,Id = 4,BrandId = 3
            });

            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
