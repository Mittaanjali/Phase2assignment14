using System;
using System.Collections.Generic;

namespace Assignment14.Models
{
    public partial class Category
    {
        public Category()
        {
            Courses = new HashSet<Course>();
        }

        public int CatId { get; set; }
        public string? CatName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
