using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class User
    {
        public  long UserId { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string Email { get; set; }
        public  string UserName { get; set; }
        public  string Password { get; set; }
        public  DateTime CreatedAt { get; set; }
        public  DateTime? UpdatedAt { get; set; }
        public  bool IsEnabled { get; set; }
       
    }
}
