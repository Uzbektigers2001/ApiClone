using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClone.Domain
{
    public class OvirPassports
    {
        public long Id { get; set; }
        public long ApplicationId { get; set; }
        public long PersonId { get; set; }
        public string PinFL { get; set; }
        public string PasspSer { get; set; }
        public string PasspNum { get; set; }
        public DateTime dateTime { get; set; }

    }
}
