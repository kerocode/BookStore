
using System.Web.Http.Filters;
using System.Web.Http.Controllers;
namespace BookStore.Web.Common
{
    public class UnitOfWorkActionFilterAttribute : ActionFilterAttribute
    {
        public virtual IActionTransactionHelper ActionTransactionHelper
        {
            get
            {
                return WebContainerManager.Get<IActionTransactionHelper>();
            }
        }

        public override bool AllowMultiple
        {
            get { return false; }
        }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            ActionTransactionHelper.BeginTransaction();
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            ActionTransactionHelper.EndTransaction(actionExecutedContext);
            ActionTransactionHelper.CloseSession();
        }
    }
}
