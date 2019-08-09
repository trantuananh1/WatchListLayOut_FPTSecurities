using System;
using System.Collections.Generic;
using System.Text;

namespace FPT_Securities.Models
{
    public class IndexModel
    {
        public string Exchange { get; set; }
        public double Price { get; set; }
        public double ChangePrice { get; set; }
        public double ChangePctPrice { get; set; }
        public double Volumn { get; set; }
    }
}
