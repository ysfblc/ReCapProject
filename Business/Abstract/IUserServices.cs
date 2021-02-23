using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IUserServices
    {
        IDataResult<List<User>> GetById(int userId);

        IResult Add(User user);
        IResult Find(User user);
        IResult Delete(User user);

    }
}
