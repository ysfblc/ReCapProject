﻿using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ILeaseService
    {
        IDataResult<List<Lease>> GetAll();
        IDataResult<List<Lease>> GetById(int leaseId);
        IResult Add(Lease lease);


    }
}
