using System;
using System.Collections.Generic;

#nullable disable

namespace BackenProjectDBV2.Models
{
    public partial class Guardian
    {
        public Guardian()
        {
            Students = new HashSet<Student>();
        }

        public int GuaId { get; set; }
        public string GuaFname { get; set; }
        public string GuaLname { get; set; }
        public string GuaSex { get; set; }
        public string GuaPhone { get; set; }
        public string GuaAdd { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
