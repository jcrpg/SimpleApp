using System;
using System.Collections.Generic;
using System.Text;
using SimpleAppJc.Domain;

namespace SimpleAppJc.Service.Interfaces
{
    public interface ICarService
    {
        IEnumerable<Car> GetAll();
        Car Get(int id);

        bool isEnquiryRecorded(Enquiry enquiry);
    }
}
