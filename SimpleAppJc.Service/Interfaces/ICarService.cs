using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
