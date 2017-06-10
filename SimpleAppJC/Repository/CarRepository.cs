using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleAppJc.Domain;
using SimpleAppJc.Service.Interfaces;

namespace SimpleAppJc.Repository
{
    public class CarRepository : ICarService
    {
        private readonly ILogService _log;

        public CarRepository(ILogService log)
        {
            _log = log;
        }
        public SimpleAppJc.Domain.Car Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SimpleAppJc.Domain.Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool isEnquiryRecorded(Enquiry enquiry)
        {
            throw new NotImplementedException();
        }
    }
}