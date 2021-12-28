using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClone.Domain.Models
{
    [Table("GetINNByPinFL")]
    public class TaxCommiteeInn
    {

        public long Id { get; set; }
        public string PinFL { get; set; }
        public string Inn { get; set; }
    }

    public class ResponseInn
    {
        public bool success { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public TaxCommiteeInn data { get; set; }
    }
}
