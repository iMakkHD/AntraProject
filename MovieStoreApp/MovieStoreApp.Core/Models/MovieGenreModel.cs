using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Models
{
    public class MovieGenreModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int MovieId { get; set; }
        [Required]
        public int GenreId { get; set; }
        public virtual MovieResponseModel Movie { get; set; }  //lazy loading
        public virtual GenreModel Genre { get; set; }  //virtual properties help in lazy loading
    }
}
