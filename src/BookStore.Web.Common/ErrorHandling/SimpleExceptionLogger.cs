using BookStore.Common.Logging;
using log4net;
using System.Web.Http.ExceptionHandling;

namespace BookStore.Web.Common.ErrorHandling
{
    public class SimpleExceptionLogger
    {
        private readonly ILog _log;

        public SimpleExceptionLogger(ILogManager logManager)
        {
            _log = logManager.GetLog(typeof(SimpleExceptionLogger));
        }

        public  void Log(ExceptionLoggerContext context)
        {
            _log.Error("Unhandled exception", context.Exception);
        }
    }
}
