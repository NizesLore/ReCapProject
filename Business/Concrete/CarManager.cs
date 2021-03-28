using Business.Abstact;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);

            }
            else
            {
                Console.WriteLine("Araba ismi minimum 2 karakter olmalı ve araba günlük fiyatı 0'dan büyük olmalıdır.");
            }
        }


        public List<Car> GetAll()
        {
            return _carDal.GetAll();

        }

        public List<Car> GetByDailyPrice()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {

            return _carDal.GetCarDetails();


        }


        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);

        }


        public List<Car> GetCarsByColorId(int id)

        {
            return _carDal.GetAll(c => c.ColorId == id);

        }
                    
    }
}

