using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.KaniniModel
{
    public partial class DrinksCart
    {
        public int Did { get; set; }
        public string Dname { get; set; }
        public string Dimage { get; set; }
        public double? Dprice { get; set; }
    }
}
