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

        public CarRepository()
        {
            //_log = log;
        }
        public SimpleAppJc.Domain.Car Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SimpleAppJc.Domain.Car> GetAll()
        {
            List<Car> newLists = new List<Car>
            {
                new Car{CarId=1,Model="Mazada 2",Make="Mazda", Year=2017,PriceType="POA",Abn=null,ContactName="Jung Chen",Phone="0412000111",Email="jung.chen@invalidemail.com",DapPrice=null,EgcPrice=null,Comments="looking to sell by a set date"},
                new Car{CarId=2,Model="Outlander",Make="Mitsubishi", Year=2017,PriceType="POA",Abn=null,ContactName="Jung Chen2",Phone="0412000112",Email="jung.chen2@invalidemail.com",DapPrice=null,EgcPrice=null,Comments="With highly advanced safety and entertainment technology, the sleek and stylish Mitsubishi Outlander takes care of your team in every way.  With generous cabin and luggage space, 2WD or AWD and a choice of 5 or 7 seats, this family SUV has your whole team covered. Outlander from Mitsubishi’s ever-reliable SUV range.Built for the time of your life"},
                new Car{CarId=3,Model="Yaris",Make="Toyato", Year=2017,PriceType="DAP",Abn=null,ContactName="Jung Chen3",Phone="0412000113",Email="jung.chen3@invalidemail.com",DapPrice=15250,EgcPrice=null,Comments="Toyota's reputation for reliability, huge dealer network and affordable maintenance costs easily make the Yaris a viable long-term ownership proposition, which is why you see so many – especially older ones including the first-generation model sold here as the Echo – still on our roads today"},
                new Car{CarId=4,Model="Camry",Make="Toyato", Year=2016,PriceType="EGC",Abn=null,ContactName="Jung Chen4",Phone="0412000114",Email="jung.chen4@invalidemail.com",DapPrice=null,EgcPrice=23070,Comments="The 2016 Toyota Camry Hybrid Atara SL is the highest specification version of Camry's revised hybrid lineup. Its strongest point might be that it doesn’t really feel different to any other Camry – until you take a look at the average fuel consumption figure (5.9L/100km over our full week of testing). It’s the infrequent trips to the bowser that make you realise this new-fangled hybrid technology might not be the unappealing black magic you initially thought it was."},
                new Car{CarId=5,Model="Everest",Make="Ford", Year=2017,PriceType="EGC",Abn="123456",ContactName=null,Phone=null,Email="jung.chen5@invalidemail.com",DapPrice=null,EgcPrice=47990,Comments="5 Door SUV,5 Cylinder, 3.2 Litre. Sports Automatic, Rear Wheel Drive. Diesel.8.4 L/100km"},
                new Car{CarId=6,Model="X3",Make="BMW", Year=2017,PriceType="EGC",Abn="123457",ContactName=null,Phone=null,Email="jung.chen6@invalidemail.com",DapPrice=null,EgcPrice=8100,Comments="5 Door SUV 6 Cylinder, 3.0 Litre Sports Automatic, 4X4 Constant Diesel 6.1 L/100km"},
                new Car{CarId=7,Model="RS7",Make="AUDI", Year=2017,PriceType="DAP",Abn=null,ContactName=null,Phone=null,Email="jung.chen7@invalidemail.com",DapPrice=259300,EgcPrice=null,Comments="5 Door Hatch 8 Cylinder, 4.0 Litre Sports Automatic, Four Wheel Drive Petrol - Premium ULP 9.6 L/100km"},
                new Car{CarId=8,Model="Accord",Make="Honda", Year=2017,PriceType="DAP",Abn=null,ContactName=null,Phone=null,Email="jung.chen8@invalidemail.com",DapPrice=52590,EgcPrice=null,Comments="4 Door Sedan 6 Cylinder, 3.5 Litre Sports Automatic, Front Wheel Drive Petrol - Unleaded ULP 9.3 L/100km"},
                new Car{CarId=9,Model="Grand Cherokee",Make="JEEP", Year=2017,PriceType="POA",Abn=null,ContactName="Jung Chen9",Phone="0412000119",Email="jung.chen9@invalidemail.com",DapPrice=null,EgcPrice=null,Comments="5 Door SUV 8 Cylinder, 6.4 Litre Sports Automatic, 4X4 On Demand Petrol - Premium ULP 14 L/100km"}
            };

            return newLists;
        }

        public bool isEnquiryRecorded(Enquiry enquiry)
        {
            throw new NotImplementedException();
        }
    }
}