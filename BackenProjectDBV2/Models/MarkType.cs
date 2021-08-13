using System;
using System.Collections.Generic;

#nullable disable

namespace BackenProjectDBV2.Models
{
    public partial class MarkType
    {
        public MarkType()
        {
            Marks = new HashSet<Mark>();
        }

        public int TypeNo { get; set; }
        public int MarMax { get; set; }
        public string MarType { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
    }
}
