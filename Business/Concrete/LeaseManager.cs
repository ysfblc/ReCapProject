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
    public class LeaseManager : ILeaseService
    {
        ILeaseDal _leaseDal;

        public LeaseManager(ILeaseDal leaseDal)
        {
            _leaseDal = leaseDal;
        }

        public IDataResult<List<Lease>> GetAll()
        {
            //iş kodlarım
            return new SuccessDataResult<List<Lease>>(_leaseDal.GetAll());
            
        }

        public IDataResult<List<Lease>> GetById(int leaseId)
        {
            return new SuccessDataResult<List<Lease>>(_leaseDal.GetAll(l => l.LeaseId == leaseId),(Messages.CarsListed));
        }

        public IResult Add(Lease lease)
        {
            var result = _leaseDal.Get(r => r.CarId == lease.CarId && r.ReturnDate == null);
            if (result != null)
            {
                return new ErrorResult(Messages.RentFail);
            }
            _leaseDal.Add(lease);
            return new SuccessResult(Messages.RentSuccess);
        }
    }
}
