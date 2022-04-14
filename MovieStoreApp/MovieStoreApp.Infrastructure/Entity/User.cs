using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Infrastructure.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public string PhoneNumber { get; set; }
        public Boolean TwoFactorEnabled { get; set; }
        public DateTime LockedEndDate { get; set; }
        public DateTime LastLoginDateTime { get; set; }
        public Boolean IsLocked { get; set; }
        public int AccessFailedCount { get; set; }

    }
}
