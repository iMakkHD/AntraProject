using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Entity
{
    public class MovieGenre
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public virtual Movie Movie { get; set; }  //lazy loading
        public virtual Genre Genre { get; set; }  //virtual properties help in lazy loading
    }
}
