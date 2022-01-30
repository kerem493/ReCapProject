using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
               new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=200, Description="Fiat Egea", ModelYear="2015"},
               new Car{Id=2, BrandId=1, ColorId=1, DailyPrice=350, Description="Honda Civic", ModelYear="2018"},
               new Car{Id=3, BrandId=2, ColorId=2, DailyPrice=250, Description="Volkswagen Golf", ModelYear="2016"},
               new Car{Id=4, BrandId=2, ColorId=3, DailyPrice=300, Description="Renault Clio", ModelYear="2020"},
               new Car{Id=4, BrandId=2, ColorId=3, DailyPrice=175, Description="Ford Focus", ModelYear="2015"} 
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);


            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

     

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

            
        }
    }
}
