using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.KaniniModel
{
    public partial class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Salary { get; set; }
        public string Dept { get; set; }
    }
}
