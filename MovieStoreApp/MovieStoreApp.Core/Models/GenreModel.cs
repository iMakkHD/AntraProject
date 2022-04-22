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
    public class GenreModel
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "Varchar")]
        [Required(ErrorMessage = "Genre Name is Required")]
        public string Name { get; set; }
        public virtual ICollection<MovieGenreModel> MovieGenre { get; set; }
    }
}
