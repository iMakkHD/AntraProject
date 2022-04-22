using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Models
{
    public class UserRoleModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public virtual User User { get; set; }  //lazy loading
        public virtual Role Role { get; set; }  //virtual properties help in lazy loading
    }
}
