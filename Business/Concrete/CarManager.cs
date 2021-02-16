﻿using Business.Abstact;
using DataAccess.Abstract;
using Entities.Concrete;
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

       
                        
        public List<Car> GetAll()
        {
            return _carDal.GetAll();

        }

        public List<Car> GetByDailyPrice()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarByBrandId(int id)
        {
            return _carDal.GetAll(c=>c.BrandId==id);

        }

        public List<Car> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
