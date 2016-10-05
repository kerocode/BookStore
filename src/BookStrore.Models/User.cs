using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStrore.Models
{
    class User
    {
        public virtual long UserId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual DateTime UpdatedAt { get; set; }
        public virtual bool IsEnabled { get; set; }
        public virtual List<OrderList> OrderList { get; set; }
    }
}
