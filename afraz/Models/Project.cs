using System;
using System.Collections.Generic;

namespace afraz.Models
{
    public partial class Project
    {
        public int Pid { get; set; }
        public int CusId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ProManid { get; set; }

        public virtual Customer Cus { get; set; } = null!;
        public virtual ProjectManager ProMan { get; set; } = null!;
    }
}
