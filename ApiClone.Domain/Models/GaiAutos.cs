using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClone.Domain.Models
{
    /// <summary>
    /// Auto transposrt datalari
    /// </summary>
    public class Vehicle
    {
        [Key]
        [Column("Id")]
        public long Id { get; set; }
        public string Model { get; set; }
        public string Mark { get; set; }
        public string RegNo { get; set; }
        public int YearOfManufacture { get; set; }
        public string AutoType { get; set; }
        public int AutoTypeCode { get; set; }
        public string TechInspectDateStart { get; set; }
        public string TechInspectDateEnd { get; set; }
        public string Dover { get; set; }
    }

    /// <summary>
    /// Response
    /// </summary>
    public class GaiAutos
    {
        public string PinFL { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }

    /// <summary>
    /// Headerdagi kelgan request
    /// </summary>
    public class KeyValues
    {
        public string PinFL { get; set; }

        public string Inn { get; set; }

        public string Document { get; set; }
    }



    /// <summary>
    /// Error bo'lganda ketaydigan answer
    /// </summary>
    public class ErrorResponse
    {
        public int ErrorCode { get; set; } = 2;
        public string ErrorDescription { get; set; } = "Ma'lumotni baza topolmadi";
    }
}
