using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.KaniniModel
{
    public partial class AddCart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int? Price { get; set; }
        public string Photo { get; set; }
        public string PlotDescription { get; set; }
    }
}
