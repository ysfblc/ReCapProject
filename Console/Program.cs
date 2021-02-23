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
            //CarTest();
            //LeaseTest();

            //UserTest();

            //LeaseGetByIdTest();

            
            LeaseManager leaseManager = new LeaseManager(new EfLeaseDal());
            System.Console.WriteLine(leaseManager.Add(new Lease { CarId = 1, CustomerId = 2, LeaseDate = DateTime.Now }).Message);


        }

        private static void LeaseGetByIdTest()
        {
            LeaseManager leaseManager = new LeaseManager(new EfLeaseDal());
            foreach (var lease in leaseManager.GetById(2).Data)
            {
                System.Console.WriteLine(lease.LeaseDate);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var user in userManager.GetById(2).Data)
            {
                System.Console.WriteLine(user.FirstName);
            }
        }

        private static void LeaseTest()
        {
            LeaseManager leaseManager = new LeaseManager(new EfLeaseDal());
            foreach (var lease in leaseManager.GetAll().Data)
            {
                System.Console.WriteLine(lease.LeaseDate);
            }
        }

        private static void CarTest()
        {

            //CarManager carManager = new CarManager(new EfCarDal());

            //var result = carManager.GetCarDetails();

            //if (result.Success==true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        System.Console.WriteLine(car.Description + "---" + car.LeaseDate + " " + "Tarihinde kiralandı");
            //    }
            //}
            //else
            //{
            //    System.Console.WriteLine(result.Message);
            //}


            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(3).Data)
            {
                System.Console.WriteLine(car.Description);

            }
        }
    }
}
