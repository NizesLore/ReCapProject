using Business.Abstact;
using Business.Constants;
using Core.Utilities.Results;
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

        public IDataResult<Car> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);

            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarAdded);
        }


        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public  IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }

         public IDataResult<List<Car>> GetByDailyPrice()
        {
            throw new NotImplementedException();
        }

       public  IDataResult<List<CarDetailDto>> GetCarDetails()
        {

            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);

            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.CarAdded);

         
        }

        public IResult Add(Car car)
        {
            {
                if (car.Description.Length > 2 && car.DailyPrice > 0)
                {
                    _carDal.Add(car);
                    return new SuccessResult(Messages.CarAdded);
                }

                return new ErrorResult(Messages.CarNameInvalid);

            }
        }

        //9th day works

        //public void Add(Car car)
        //{
        //    if (car.Description.Length >= 2 && car.DailyPrice > 0)
        //    {
        //        _carDal.Add(car);

        //    }
        //    else
        //    {
        //        Console.WriteLine("Araba ismi minimum 2 karakter olmalı ve araba günlük fiyatı 0'dan büyük olmalıdır.");
        //    }
        //}


        //public List<Car> GetAll()
        //{
        //    return _carDal.GetAll();

        //}

        //public List<Car> GetByDailyPrice()
        //{
        //    throw new NotImplementedException();
        //}

        //public Car GetById(int Id)
        //{
        //    return _carDal.Get(c=>c.Id==Id);
        //}

        //public List<CarDetailDto> GetCarDetails()
        //{
        //    return _carDal.GetCarDetails();
        //}

        //public List<Car> GetCarsByBrandId(int id)
        //{
        //    return _carDal.GetAll(c => c.BrandId == id);
        //}

        //public List<Car> GetCarsByColorId(int id)
        //{
        //    return _carDal.GetAll(c => c.ColorId == id);
        //}

        // public IResult Add(Car car)
        //{
        //    if (car.CarName.Length<2)
        //    {
        //        return new ErrorResult(Messages.CarNameInvalid);
        //    }
        //    _carDal.Add(car);
        //    return new SuccessResult(Messages.CarAdded);

        //}

    }
}

