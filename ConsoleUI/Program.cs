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

            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Delete(new Users
            {
                Email = "asd@asd.com",
                FirstName = "TESTKULLANICIADI",
                LastName = "TESTSOYAD",
                Password = "1234",
                UserId = 2//bu değer mevcut müşterilerden birinin idsi


            });






            //CarTest();

            //BrandTest();

            //ColorTest();

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
