using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
   public interface ICarDal : IEntityRepository<Car>
    {
        //List<Car> GetAll(Expression<Func<Car, bool>> filter = null);
        //Car Get(Expression<Func<Car, bool>> filter);
        //void Add(Car entity);
        //void Update(Car entity);
        //void Delete(Car entity);
        //List<Car> GetAllByCar(int id);


    }
}
