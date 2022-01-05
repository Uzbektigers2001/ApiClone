using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClone.Domain.Models
{
    public class CadastralRegion
    {
        public List<Vladeniya> Vladeniya { get; set; }
        public int result { get; set; }
    }

    public class RequestKey
    {
        public string TextZaprosa { get; set; }
    }

    [Table("GetCadastralRegionByPinfl")]
    public class Vladeniya
    {
        [Key]
        [Column("Id")]
        public long Id { get; set; }
        
        [Column("KadType")]
        public string cad_type { get; set; }
        
        [Column("KadNo")]
        public string cad_num { get; set; }
        
        [Column("CadRegion")]
        public string region { get; set; }
        
        [Column("CadDistrict")]
        public string district { get; set; }
        
        [Column("Adres")]
        public string address { get; set; }
        
        [Column("Name")]
        public string mahalla { get; set; }
        
        [Column("owner")]
        public string owner { get; set; }
        
        [Column("Inn")]
        public string inn { get; set; }
        
        [Column("PinFL")]
        public string pinfl { get; set; }
        
        [Column("Document")]
        public string passport { get; set; }
        
        [Column("Area")]
        public decimal? area { get; set; }
        
        [Column("AreaLand")]
        public string area_land { get; set; }
        
        [Column("AreaZ")]
        public decimal? area_z { get; set; }
        
        [Column("Ploshad")]
        public decimal? area_j { get; set; }
        
        [Column("OwnerPercentage")]
        public decimal? percent { get; set; }
    }
}
