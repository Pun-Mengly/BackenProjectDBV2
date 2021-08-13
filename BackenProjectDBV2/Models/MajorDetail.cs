using System;
using System.Collections.Generic;

#nullable disable

namespace BackenProjectDBV2.Models
{
    public partial class MajorDetail
    {
        public int? MajNo { get; set; }
        public int? StuId { get; set; }

        public virtual Major MajNoNavigation { get; set; }
        public virtual Student Stu { get; set; }
    }
}
