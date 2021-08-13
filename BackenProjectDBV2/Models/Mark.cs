using System;
using System.Collections.Generic;

#nullable disable

namespace BackenProjectDBV2.Models
{
    public partial class Mark
    {
        public int MarNo { get; set; }
        public int MarTotal { get; set; }
        public DateTime MarDate { get; set; }
        public int? TypeNo { get; set; }
        public int? SubNo { get; set; }
        public int? StuId { get; set; }

        public virtual Student Stu { get; set; }
        public virtual Subject SubNoNavigation { get; set; }
        public virtual MarkType TypeNoNavigation { get; set; }
    }
}
