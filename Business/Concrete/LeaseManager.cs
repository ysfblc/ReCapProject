using Business.Abstract;
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

        public List<Lease> GetAll()
        {
            //iş kodlarım
            return _leaseDal.GetAll();
        }

        public Lease GetById(int leaseId)
        {
            return _leaseDal.Get(l => l.LeaseId == leaseId);
        }
    }
}
