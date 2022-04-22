using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Models
{
    public class PurchaseModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PurchaseNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime PurchaseDateTime { get; set; }
        public int MovieId { get; set; }
        public virtual User User { get; set; }  //lazy loading
        public virtual Movie Movie { get; set; }  //virtual properties help in lazy loading
    }
}
