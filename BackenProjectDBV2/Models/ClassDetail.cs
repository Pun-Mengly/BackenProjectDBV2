using System;
using System.Collections.Generic;

#nullable disable

namespace BackenProjectDBV2.Models
{
    public partial class ClassDetail
    {
        public int? ClaNo { get; set; }
        public int? MajNo { get; set; }

        public virtual Class ClaNoNavigation { get; set; }
        public virtual Major MajNoNavigation { get; set; }
    }
}
