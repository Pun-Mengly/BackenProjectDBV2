using System;
using System.Collections.Generic;

#nullable disable

namespace BackenProjectDBV2.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Marks = new HashSet<Mark>();
            Teachers = new HashSet<Teacher>();
        }

        public int SubNo { get; set; }
        public string SubName { get; set; }
        public int? SubDur { get; set; }
        public int? MajNo { get; set; }

        public virtual Major MajNoNavigation { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
