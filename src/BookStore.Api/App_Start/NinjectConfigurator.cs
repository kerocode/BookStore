using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore.Common;
using BookStore.Common.Logging;
using log4net.Config;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Context;
using Ninject.Activation;
using Ninject.Web.Common;
using BookStore.Data.SqlServer.Mapping;
using BookStore.Web.Common;
using BookStore.Web.Common.Security;
using BookStore.Common.Security;

namespace BookStore.Api.App_Start
{
    public class NinjectConfigurator
    {
        public void Configure(IKernel container) { AddBindings(container); }

        private void AddBindings(IKernel container)
        {
            ConfigureLog4net(container);
            ConfigureNHibernate(container);
            ConfigureUserSession(container);
            container.Bind<IDateTime>().To<DateTimeAdapter>().InSingletonScope();
        }

        private void ConfigureLog4net(IKernel container)
        {
            XmlConfigurator.Configure();
            var logManager = new LogManagerAdapter();
            container.Bind<ILogManager>().ToConstant(logManager);
        }

        private void ConfigureNHibernate(IKernel container)
        {
            var sessionFactory = Fluently.Configure()
                .Database(MsSqlCeConfiguration.MsSqlCe40.ConnectionString(
                    c => c.FromConnectionStringWithKey("BookStoreDb")))
                    .CurrentSessionContext("web")
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<OrderMapping>())
                    .BuildSessionFactory();
            container.Bind<ISessionFactory>().ToConstant(sessionFactory);
            container.Bind<ISession>().ToMethod(CreateSession).InRequestScope();
            container.Bind<IActionTransactionHelper>().To<ActionTransactionHelper>().InRequestScope();
        }
        private void ConfigureUserSession(IKernel container)
        {
            var userSession = new UserSession();
            container.Bind<IUserSession>().ToConstant(userSession).InSingletonScope();
            container.Bind<IWebUserSession>().ToConstant(userSession).InSingletonScope();
        }

        private ISession CreateSession(IContext context)
        {
            var sessionFactory = context.Kernel.Get<ISessionFactory>();
            if (!CurrentSessionContext.HasBind(sessionFactory))
            {
                var session = sessionFactory.OpenSession();
                CurrentSessionContext.Bind(session);
            }

            return sessionFactory.GetCurrentSession();
        }


    }
}