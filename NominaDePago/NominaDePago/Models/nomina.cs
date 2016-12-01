using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NominaDePago.Models
{
    public class Nomina
    {
        [Key]
        public int Id { get; set; }
        [Required]
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
        [Required]
        public int EmpleadoId { get; set; }

        [ForeignKey("EmpleadoId")]
        public virtual EmpleadoModel Empleado { get; set; }// virtual hace que no sea mapiada, ni heredada
    }
}