﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore.Common;
using BookStore.Common.Logging;
using log4net.Config;
namespace BookStore.Api.App_Start
{
    public class NinjectConfigurator
    {
        public void Configure(IKernel container) { AddBindings(container); }

        private void AddBindings(IKernel container)
        {
            ConfigureLog4net(container);
            container.Bind<IDateTime>().To<DateTimeAdapter>().InSingletonScope();
        }

        private void ConfigureLog4net(IKernel container)
        {
            XmlConfigurator.Configure();
            var logManager = new LogManagerAdapter();
            container.Bind<ILogManager>().ToConstant(logManager);
        }
    }
}