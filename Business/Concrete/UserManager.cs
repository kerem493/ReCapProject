using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
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

        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {

            _userDal.Add(user);
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

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserId == id));
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
