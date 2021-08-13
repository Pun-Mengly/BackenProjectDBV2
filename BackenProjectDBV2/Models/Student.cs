using System;
using System.Collections.Generic;

#nullable disable

namespace BackenProjectDBV2.Models
{
    public partial class Student
    {
        public Student()
        {
            Attendances = new HashSet<Attendance>();
            Marks = new HashSet<Mark>();
        }

        public int StuId { get; set; }
        public string StuFname { get; set; }
        public string StuLname { get; set; }
        public string StuSex { get; set; }
        public DateTime StuDob { get; set; }
        public string StuPhone { get; set; }
        public string StuAdd { get; set; }
        public int StuYear { get; set; }
        public int? GuaId { get; set; }

        public virtual Guardian Gua { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
    }
}
