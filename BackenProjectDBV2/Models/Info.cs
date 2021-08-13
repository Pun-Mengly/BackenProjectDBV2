using System;
using System.Collections.Generic;

#nullable disable

namespace BackenProjectDBV2.Models
{
    public partial class Info
    {
        public int Id { get; set; }
        public string Context { get; set; }
        public DateTime? Date { get; set; }
        public string Image { get; set; }
    }
}
