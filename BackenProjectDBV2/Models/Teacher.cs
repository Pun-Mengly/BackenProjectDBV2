using System;
using System.Collections.Generic;

#nullable disable

namespace BackenProjectDBV2.Models
{
    public partial class Teacher
    {
        public int TeaId { get; set; }
        public string TeaFname { get; set; }
        public string TeaLname { get; set; }
        public string TeaSex { get; set; }
        public DateTime TeaDob { get; set; }
        public string TeaPhone { get; set; }
        public string TeaAdd { get; set; }
        public int? SubNo { get; set; }

        public virtual Subject SubNoNavigation { get; set; }
    }
}
