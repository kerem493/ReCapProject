using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //RentalManagement();

            //CarColorandBrandOperation();

            //ColorOperation();

            //UserOperation();

            //CarTest();

            //BrandTest();

            //ColorTest();

        }

        private static void RentalManagement()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Delete(new Rental
            {
                Id = 1,
                CustomerId = 1,
                RentDate = new DateTime(2022, 2, 6),
                ReturnDate = new DateTime(2022, 2, 12)
            });
        }

        private static void CarColorandBrandOperation()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var r = carManager.GetCarDetails();
            if (r.Success)
            {
                foreach (var item in r.Data)
                {
                    Console.WriteLine("Aracın rengi : " + item.ColorName + " Aracın modeli : " + item.BrandName);
                }
            }
            else
            {
                Console.WriteLine(r.Message);
            }
        }

        private static void ColorOperation()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var item in colorManager.GetCarsByColorId(3).Data)
            {
                Console.WriteLine("Seçilen renk : " + item.ColorName);
            }
        }

        private static void UserOperation()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                Email = "asd@asd.com",
                FirstName = "Kerem",
                LastName = "KORKMAZ",
                Password = "12345",
                UserId = 3


            });
        }

        //private static void ColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.ColorId + " " + color.ColorName);            }
        //}

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.BrandId + " " + brand.BrandName);
        //    }
        //}

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.ColorName + " " + car.Id + " " + car.Description);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
