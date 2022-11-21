using System;
using System.Collections.Generic;

namespace afraz.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Projects = new HashSet<Project>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Email { get; set; } = null!;
        public long Mobile { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
