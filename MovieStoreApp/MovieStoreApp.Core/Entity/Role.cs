using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Entity
{
    public class Role
    {
        public int Id { get; set; }
        [MaxLength(300)]
        [Column(TypeName = "Varchar")]
        public string Name { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
