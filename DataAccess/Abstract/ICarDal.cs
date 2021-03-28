using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.DTOs;

namespace DataAccess.Abstract
{
   public interface ICarDal : IEntityRepository<Car>
    {

        List<CarDetailDto> GetCarDetails();


    }
}
