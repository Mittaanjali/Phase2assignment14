using System;
using System.Collections.Generic;

namespace Assignment14.Models
{
    public partial class Course
    {
        public int Cid { get; set; }
        public string? Cname { get; set; }
        public double? Cfee { get; set; }
        public DateTime? CstartDate { get; set; }
        public int? CatId { get; set; }

        public virtual Category? Cat { get; set; }
    }
}
