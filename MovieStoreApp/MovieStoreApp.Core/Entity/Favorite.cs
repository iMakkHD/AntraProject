﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Entity
{
    public class Favorite
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }  //lazy loading
        public virtual Movie Movie { get; set; }  //virtual properties help in lazy loading
    }
}
