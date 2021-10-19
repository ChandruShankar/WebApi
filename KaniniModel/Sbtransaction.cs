using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.KaniniModel
{
    public partial class Sbtransaction
    {
        public int Transid { get; set; }
        public DateTime? Transactdate { get; set; }
        public int? Accno { get; set; }
        public double? Amt { get; set; }
        public string Transtype { get; set; }

        public virtual Sbaccount AccnoNavigation { get; set; }
    }
}
