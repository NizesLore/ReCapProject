using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBrandDal:IEntityRepository<Brand>
    {

        //List<Brand> GetById(int id);
        //List<Brand> GetAll();
        //void Add(Brand brand);
        //void Update(Brand brand);
        //void Delete(Brand brand);
    }
}
