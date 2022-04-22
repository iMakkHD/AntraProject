using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Entity
{
    public class Trailer
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        [MaxLength(250)]
        [Column(TypeName = "Varchar")]
        public string TrailerUrl { get; set; }
        [MaxLength(250)]
        [Column(TypeName = "Varchar")]
        public string Name { get; set; }
        //Missing virtual component????????????
    }
}
