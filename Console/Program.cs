using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
//using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Object-DTO
            CarTest();
            //LeaseTest();

        }

        private static void LeaseTest()
        {
            LeaseManager leaseManager = new LeaseManager(new EfLeaseDal());
            foreach (var lease in leaseManager.GetAll())
            {
                System.Console.WriteLine(lease.LeaseDate);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                System.Console.WriteLine(car.Description+"---"+car.LeaseDate+" "+"Tarihinde kiralandı");

            }
        }
    }
}
