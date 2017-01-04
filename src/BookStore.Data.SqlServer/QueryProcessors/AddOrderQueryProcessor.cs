using BookStore.Data.QueryProcessors;
using BookStore.Data.Exceptions;
using BookStore.Data.Entities;
using BookStore.Common;
using BookStore.Common.Security;
using NHibernate;
using NHibernate.Util;

namespace BookStore.Data.SqlServer.QueryProcessors
{
    public class AddOrderQueryProcessor : IAddOrderQueryProcesso
    {
        private readonly IDateTime _dateTime;
        private readonly ISession _session;
        private readonly IUserSession _userSession;

        public AddOrderQueryProcessor(ISession session, IUserSession userSession, IDateTime dateTime)
        {
            _session = session;
            _userSession = userSession;
            _dateTime = dateTime;
        }

        public void AddOrder(Order order)
        {
            order.OrderDate = _dateTime.UtcNow;
            task.Status = _session.QueryOver<Status>().Where(x => x.Name == "Not Started").SingleOrDefault();
            order.UserId = _session.QueryOver<User>().Where(x => x.UserId == _userSession.us).SingleOrDefault();

            if (task.Users != null && task.Users.Any())
            {
                for (var i = 0; i < task.Users.Count; ++i)
                {
                    var user = task.Users[i];
                    var persistedUser = _session.Get<User>(user.UserId);
                    if (persistedUser == null)
                    {
                        throw new ChildObjectNotFoundException("User not found");
                    }
                    task.Users[i] = persistedUser;
                }
            }

            _session.SaveOrUpdate(task);
        }
    }
}
