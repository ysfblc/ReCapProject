using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ILeaseService
    {
        List<Lease> GetAll();
        Lease GetById(int leaseId);


    }
}
