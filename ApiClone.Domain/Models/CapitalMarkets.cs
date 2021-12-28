using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClone.Domain.Models
{
    public class CapitalMarkets
    {
        //response
        public string INN { get; set; }
        public string FIO { get; set; }
        public int QUANTITY { get; set; }
        public int NOMINAL { get; set; }
        public int AMOUNT { get; set; }
        public string STOCK_CODE { get; set; }
        public string STOCK_NAME { get; set; }

    }

    public class GetPersonCapitalMarketsForApiClone
    {
        public long Id { get; set; }
        public string Inn { get; set; }
        public string FIO { get; set; }
        public int Quantity { get; set; }
        public int Nominal { get; set; }
        public string Amount { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
    }

    public class BadRequestCapitalMarkets
    {
        public string error { get; } = "not found";
    }
}
