using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClone.Domain.Models
{
    public class MoLRequestVm
    {
        public string jsonrpc { get; set; }
        public int id { get; set; }
        public string method { get; set; }
        public Params Params { get; set; }
    }

    public class Params
    {
        public Body body { get; set; }
    }
    public class Body
    {
        public string pin { get; set; }
        public string pinfl { get; set; }
        public string passport_sn { get; set; }
        public string passport_num { get; set; }
    }
    public class NapmEndPointModel
    {
        public string Id => PinFL;
        public string document { get; set; }
        public string PinFL { get; set; }
        public string TaxCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string lang { get; set; }
        public long PersonID { get; set; }
        public string DateOfBirth { get; set; }
        public long ApplicationID { get; set; }
        public string Format { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string Username { get; set; }
        public string VerificationLink { get; set; }
        public string VerificationEndpoint { get; set; }
        public string PassportNo { get; set; }
        public string PassportSeriesId { get; set; }
        public string Host { get; set; }
        public string Method { get; set; }
        public string JsonRpc { get; set; }
    }
}
