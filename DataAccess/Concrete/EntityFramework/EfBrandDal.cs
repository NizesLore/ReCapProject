﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand brand)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAllBy(int id)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAllByCar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}