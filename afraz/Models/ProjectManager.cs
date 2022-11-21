using System;
using System.Collections.Generic;

namespace afraz.Models
{
    public partial class ProjectManager
    {
        public ProjectManager()
        {
            Projects = new HashSet<Project>();
        }

        public int Pmid { get; set; }
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public long Mobile { get; set; }
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public long Pincode { get; set; }
        public string Password { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;

        public virtual ICollection<Project> Projects { get; set; }
    }
}
