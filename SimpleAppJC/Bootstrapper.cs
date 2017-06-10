using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using SimpleAppJc.Domain;
using SimpleAppJc.Service.Interfaces;
using SimpleAppJc.Repository;

namespace SimpleAppJc
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      container.RegisterType<ICarService, CarRepository>();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();    
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}