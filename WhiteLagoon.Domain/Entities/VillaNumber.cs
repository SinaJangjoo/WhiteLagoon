using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLagoon.Domain.Entities
{
    public class VillaNumber
    {
        //Have Primary Key without default identity column
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] //That means database will not automatically generate that as an identity column
        [Display(Name = "Villa Number")]
        public int Villa_Number { get; set; }


        [ForeignKey("Villa")]
        public int VillaId { get; set; }
        public Villa Villa { get; set; }


        public string? SpecialDetails { get; set; }
    }
}
