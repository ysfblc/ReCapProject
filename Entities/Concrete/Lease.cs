using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Lease:IEntity
    {
        public int CarId { get; set; }
        public int LeaseId { get; set; }
        public DateTime LeaseDate { get; set; }
    }
}
