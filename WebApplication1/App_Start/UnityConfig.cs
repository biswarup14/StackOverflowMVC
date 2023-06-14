using StackOverflowMVC.ServiceLayer;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.WebApi;

namespace WebApplication1
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IQuestionsService, QuestionsService>();
            container.RegisterType<IUsersService, UsersService>();
            container.RegisterType<ICategoriesService, CategoriesService>();
            container.RegisterType<IAnswersService, AnswersService>();

            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}