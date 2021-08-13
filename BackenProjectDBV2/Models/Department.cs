using System;
using System.Collections.Generic;

#nullable disable

namespace BackenProjectDBV2.Models
{
    public partial class Department
    {
        public Department()
        {
            Majors = new HashSet<Major>();
        }

        public int DepNo { get; set; }
        public string DepName { get; set; }

        public virtual ICollection<Major> Majors { get; set; }
    }
}
