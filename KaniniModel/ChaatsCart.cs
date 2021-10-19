using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.KaniniModel
{
    public partial class ChaatsCart
    {
        public int Cid { get; set; }
        public string Cname { get; set; }
        public string Cimage { get; set; }
        public double? Cprice { get; set; }
    }
}
