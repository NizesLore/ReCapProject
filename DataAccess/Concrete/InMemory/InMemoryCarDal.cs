using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {

                new Car{Id=1, BrandId=1, ColorId=1,ModelYear=2021,DailyPrice=179,Description="Fiat "},
                new Car{Id=2, BrandId=1, ColorId=2,ModelYear=2020,DailyPrice=150,Description="Renault "},
                new Car{Id=3, BrandId=1, ColorId=3,ModelYear=2019,DailyPrice=200,Description="Nissan "},
                new Car{Id=4, BrandId=2, ColorId=4,ModelYear=2018,DailyPrice=160,Description="Peugeot"},
                new Car{Id=5, BrandId=2, ColorId=5,ModelYear=2017,DailyPrice=120,Description="Dacia"},

            };

        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllBy(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByCar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c=>c.Id==id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;


        }
    }
}
