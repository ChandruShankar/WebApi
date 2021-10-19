using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.KaniniModel
{
    public partial class ProductsCart
    {
        public int Productid { get; set; }
        public string Productname { get; set; }
        public int? Productprice { get; set; }
        public string ProductImage { get; set; }
    }
}
