using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperOrmProject08.Model
{
    public class Customer
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsFirstTimeLogin { get; set; }
        public int AccessFailedCount { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }

        public Role Role { get; set; }
    }
}
