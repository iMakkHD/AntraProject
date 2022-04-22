using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Models
{
    public class RoleModel
    {
        public int Id { get; set; }
        [MaxLength(300)]
        [Column(TypeName = "Varchar")]
        public string Name { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
