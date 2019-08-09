using System;
using System.Collections.Generic;
using System.Text;

namespace FPT_Securities.Models
{
    public class WatchList
    {
        public string Symbol { get; set; }
        public double MatchPrice { get; set; }
        public double Change { get; set; }
        public double ChangePct { get; set; }
        public double Quantity { get; set; }
        public string MatchColor { get; set; }

       
    }
}
