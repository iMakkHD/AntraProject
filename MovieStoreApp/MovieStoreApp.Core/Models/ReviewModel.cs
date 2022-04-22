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
    public class ReviewModel
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public decimal Rating { get; set; }
        [MaxLength(1000)]
        [Column(TypeName = "Varchar")]
        public string ReviewText { get; set; }
        public virtual User User { get; set; }  //lazy loading
        public virtual Movie Movie { get; set; }  //virtual properties help in lazy loading
    }
}
