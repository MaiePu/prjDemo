using System;
using System.Collections.Generic;

namespace prjDemo.Models
{
    public partial class TTransaction
    {
        public int FId { get; set; }
        public string? FDate { get; set; }
        public string? FCustomerId { get; set; }
        public string? FProductId { get; set; }
        public decimal? FCount { get; set; }
        public decimal? FPrice { get; set; }
    }
}
