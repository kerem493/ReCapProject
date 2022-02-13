using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rentals)
        {
            if (rentals.ReturnDate == null)
            {
                _rentalDal.Add(rentals);
                return new ErrorResult(Messages.CarNoReturnDate);
            }
            _rentalDal.Add(rentals);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Rental rentals)
        {
            _rentalDal.Delete(rentals);
            return new SuccessResult("Araç kiralama işlemi iptal edildi");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        public IResult Update(Rental rentals)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Rental>> IRentalService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
