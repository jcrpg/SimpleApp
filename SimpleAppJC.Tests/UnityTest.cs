using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAppJc.Service.Interfaces;
using SimpleAppJc.Repository;
namespace SimpleAppJC.Tests
{
    [TestClass]
    public class UnityTest
    {
        private IUnityContainer _unityContainer;

        [TestMethod]
        public void MyTestInitialize()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<ICarService, CarRepository>();
            // e.g. container.RegisterType<ITestService, TestService>(); 

            Assert.IsTrue(container.Registrations.Count() == 2);
        }

        [TestMethod]
        public void GetListOfCars()
        {
            // Arrange
            IUnityContainer myContainer = new UnityContainer();

            myContainer.RegisterType<ICarService, CarRepository>();

            CarRepository myClass = new CarRepository();

            Assert.IsNotNull(myClass.GetAll());
        }
    }
}
