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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User users)
        {
            if (users.FirstName.Length <2)
            {
                return new ErrorResult(Messages.UsersNameInvalid);
            }

            _userDal.Add(users);
            return new SuccessResult(Messages.UserAdded);

        }

       

        public IResult Delete(User users)
        {
            if (users.FirstName.Length < 2)
            {
                return new ErrorResult(Messages.UsersNameInvalid);
            }
            _userDal.Delete(users);
            return new SuccessResult(Messages.UserDeleted);
        }

        

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>> (_userDal.GetAll());
        }

        public IResult Update(User users)
        {
            if (users.FirstName.Length < 2)
            {
                return new ErrorResult(Messages.UsersNameInvalid);
            }
            _userDal.Update(users);
            return new SuccessResult(Messages.UserUpdated);
        }

        

        IDataResult<List<User>> IUserService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
