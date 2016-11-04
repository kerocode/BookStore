using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Filters;
namespace BookStore.Web.Common
{
    public interface IActionTransactionHelper
    {
        void BeginTransaction();
        void EndTransaction(HttpActionExecutedContext filterContext);
        void CloseSession();
    }
}
