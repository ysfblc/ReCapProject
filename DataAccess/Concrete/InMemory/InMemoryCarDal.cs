using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace DataAccess.Concrete.InMemory
//{
    //public class InMemoryCarDal : ICarDal
    //{
    //    List<Car> _car;
    //    public InMemoryCarDal()
    //    {
    //        _car = new List<Car>
    //        {
    //            new Car{Id=1, ColorId=2, DailyPrice=230, ModelYear=2013, Description="Otomatik Vites Hyundai i20"},
    //            new Car{Id=2, ColorId=2, DailyPrice=430, ModelYear=2013, Description="Manuel Vites Seat Leon"},
    //            new Car{Id=3, ColorId=1, DailyPrice=290, ModelYear=2013, Description="Otomatik Vites Renault Clio"},
    //            new Car{Id=4, ColorId=1, DailyPrice=270, ModelYear=2013, Description="Manuel Vites Toyota Auris"},
    //        };
    //    }

    //    public void Add(Car car)
    //    {
    //        _car.Add(car);
    //    }


    //    public void Delete(Car car)
    //    {
    //        Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
    //    }

    //    public List<Car> GetAll()
    //    {
    //        return _car;
    //    }

    //    public List<Car> GetById(int colorId)
    //    {
    //        return _car.Where(c => c.ColorId == colorId).ToList();
    //    }

    //    public void Update(Car car)
    //    {
    //        Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
    //        carToUpdate.DailyPrice = car.DailyPrice;
    //        carToUpdate.ColorId = car.ColorId;
    //        carToUpdate.Description = car.Description;
    //    }
//    }
//}
