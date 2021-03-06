﻿using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarServices
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<Car>> GetCarsByModelYear(decimal min, decimal max);
        IDataResult<List<Car>> GetCarsByDailyPrice(decimal min);
        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult Add(Car car);

        IResult Update(Car car);

        IResult Delete(Car car);


    }
}
