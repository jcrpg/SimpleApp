using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleAppJc.Domain;

namespace SimpleAppJc.Service.Interfaces
{
    public interface ILogService
    {
        void fileLogging();

        void saveEnquiryToFile(CarViewModel car);
    }
}
