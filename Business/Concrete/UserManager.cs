using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserServices
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length<2)
            {
                return new ErrorDataResult<User>(Messages.UserNameInvalid);
            }
            _userDal.Add(user);
            return new SuccessDataResult<User>(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessDataResult<User>(Messages.CarsListed);
        }

        public IResult Find(User user)
        {
            if (user.FirstName==user.FirstName)
            {
                return new ErrorDataResult<User>(Messages.UserFound);
            }
            return new SuccessDataResult<User>(Messages.UserNotFound);
        }

        public IDataResult<List<User>> GetById(int userId)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.UserId == userId));
        }

    }
}
