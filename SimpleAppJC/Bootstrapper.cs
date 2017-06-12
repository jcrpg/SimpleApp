using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using SimpleAppJc.Domain;
using SimpleAppJc.Service.Interfaces;
using SimpleAppJc.Repository;
using UnityLog4NetExtension.Log4Net;
using SimpleAppJc.Implementations;
namespace SimpleAppJc
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();
            
      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<ICarService, CarRepository>();
            container.AddNewExtension<LogInit>();
            container.AddNewExtension<Log4NetExtension>();

            RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}