using Autofac;
using Autofac.Integration.Mvc;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DrDemo_MvcWebUI.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DrDemo_MvcWebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<BookManager>().As<IBookService>();
            builder.RegisterType<EfBookDal>().As<IBookDal>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<AuthorManager>().As<IAuthorService>();
            builder.RegisterType<EfAuthorDal>().As<IAuthorDal>();

            builder.RegisterType<PublisherManager>().As<IPublisherService>();
            builder.RegisterType<EfPublisherDal>().As<IPublisherDal>();

            builder.RegisterType<ShopManager>().As<IShopService>();
            builder.RegisterType<EfShopDal>().As<IShopDal>();

            builder.RegisterType<AppUserManager>().As<IAppUserService>();
            builder.RegisterType<EfAppUserDal>().As<IAppUserDal>();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
