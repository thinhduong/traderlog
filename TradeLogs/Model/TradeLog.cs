using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradeLogs.Model
{
    [Table("tradelog")]
    public class TradeLog
    {
        [Key]
        public int LogId { get; set; }

        public DateTime InsertedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string FromCurrency { get; set; }

        public string ToCurrency { get; set; }

        public double FromAmount { get; set; }

        public double ChangeRate { get; set; }

        public double ToAmount { get; set; }

        public string CustomerName { get; set; }

        public string Phone { get; set; }

        public string UserName { get; set; }

    }
}
