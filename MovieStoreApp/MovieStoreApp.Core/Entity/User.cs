using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Entity
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar")]
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar")]
        public string Email { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar")]
        public string HashedPassword { get; set; }
        [MaxLength(400)]
        [Column(TypeName = "Varchar")]
        public string Salt { get; set; }
        [MaxLength(50)]
        [Column(TypeName = "Varchar")]
        public string PhoneNumber { get; set; }
        public Boolean TwoFactorEnabled { get; set; }
        public DateTime LockedEndDate { get; set; }
        public DateTime LastLoginDateTime { get; set; }
        public Boolean IsLocked { get; set; }
        public int AccessFailedCount { get; set; }

        //Missing virtual components

    }
}
