using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.KaniniModel
{
    public partial class Sbaccount
    {
        public Sbaccount()
        {
            Sbtransactions = new HashSet<Sbtransaction>();
        }

        public int Accno { get; set; }
        public string Custname { get; set; }
        public string Custaddress { get; set; }
        public double? Balance { get; set; }
        public string Transtype { get; set; }

        public virtual ICollection<Sbtransaction> Sbtransactions { get; set; }
    }
}
