using System;
using System.Collections.Generic;

#nullable disable

namespace BackenProjectDBV2.Models
{
    public partial class Major
    {
        public Major()
        {
            Subjects = new HashSet<Subject>();
        }

        public int MajNo { get; set; }
        public int MajDur { get; set; }
        public string MajName { get; set; }
        public string MajDes { get; set; }
        public int? DepNo { get; set; }

        public virtual Department DepNoNavigation { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
