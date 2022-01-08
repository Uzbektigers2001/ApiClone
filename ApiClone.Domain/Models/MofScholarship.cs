using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClone.Domain.Models
{
    public class MofScholarship
    {
        public string PinFL { get; set; }
        
        public string Name { get; set; }

        public List<InCome> InComes { get; set; }
    }

    public class PinFLWithName
    {
        [Key]
        public string PinFL { get; set; }

        public string Name { get; set; }
    }

    public class InCome
    {
        [Key]
        [Column("Id")]
        public long Id { get; set; }

        [Column("IncomeMonth")]
        public int? Month { get; set; }

        [Column("IncomeYear")]
        public int? Year { get; set; }

        [Column("Amount")]
        public string Amount { get; set; }

        [Column("AppType")]
        public string IncomeType { get; set; }
    }

    public class ErrorMofScholarship
    {
        public long pinfl { get; set; } = 0;

        public string success { get; set; } = "false";

        public int errorCode { get; set; } = 404;

    }
}



//{"PinFL":"50109016060017","Name":"RAVSHANOV NIYAZBEK ALISHEROVOCH","Income":[{"Month":7,"Year":2021,"Amount":470800.00,"IncomeType":null}]}
