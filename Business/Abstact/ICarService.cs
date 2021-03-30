using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstact
{
    public interface ICarService
    {
        IDataResult<Car> GetById(int Id);

        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);

        IDataResult<List<Car>> GetByDailyPrice();

        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add (Car car);
    }
    

}

