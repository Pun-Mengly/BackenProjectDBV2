using System;
using System.Collections.Generic;

#nullable disable

namespace BackenProjectDBV2.Models
{
    public partial class Attendance
    {
        public int AttNo { get; set; }
        public DateTime AttDate { get; set; }
        public int? StuId { get; set; }

        public virtual Student Stu { get; set; }
    }
}
