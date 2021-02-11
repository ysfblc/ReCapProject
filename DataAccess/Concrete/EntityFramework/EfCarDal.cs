using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDbContext context=new CarDbContext())
            {
                var result = from c in context.Cars
                             join l in context.Leases
                             on c.CarId equals l.CarId
                             select new CarDetailDto
                             {
                                 CarId=c.CarId,LeaseDate=l.LeaseDate,DailyPrice=c.DailyPrice,
                                 Description=c.Description
                             };
                return result.ToList();
                             
            }
        }
    }
}
