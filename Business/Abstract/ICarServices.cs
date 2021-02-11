﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarServices
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        List<Car> GetCarsByModelYear(decimal min, decimal max);
        List<Car> GetCarsByDailyPrice(decimal min);
        List<CarDetailDto> GetCarDetails();


    }
}
