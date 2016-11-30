using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NominaDePago.Models
{
    public class nomina
    {
        [Key]
        public int BonoTransporte { get; set; }
        [Required]
        public int BonoALimenticio { get; set; }
        [Required]
        public int HorasExtras { get; set; }
        [Required]
        public int TotalAsignaciones { get; set; }
        [Required]
        public int Seguro { get; set; }
        [Required]
        public int Pension { get; set; }
        public int TotalDeducciones { get; set; }
        [Required]
        public int SalarioAPagar { get; set; }
    }
}