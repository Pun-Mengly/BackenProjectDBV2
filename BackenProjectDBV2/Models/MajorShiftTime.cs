using System;
using System.Collections.Generic;

#nullable disable

namespace BackenProjectDBV2.Models
{
    public partial class MajorShiftTime
    {
        public int? MajNo { get; set; }
        public string MajTime { get; set; }

        public virtual Major MajNoNavigation { get; set; }
    }
}
