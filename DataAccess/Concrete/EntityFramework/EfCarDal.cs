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
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, EfCarRentalContext>, ICarDal
    {


        public List<CarDetailDto> GetCarDetails()
        {
            using (EfCarRentalContext context = new EfCarRentalContext())
            {
                var result = from a in context.Cars
                             join b in context.Brands
                             on a.BrandId equals b.BrandId
                             join c in context.Colors
                             on a.ColorId equals c.ColorId
                             select new CarDetailDto
                             {
                                 Id = a.Id,
                                 Description = a.Description,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice = a.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
