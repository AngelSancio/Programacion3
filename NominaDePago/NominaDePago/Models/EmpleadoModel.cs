using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NominaDePago.Models
{
    public class EmpleadoModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Identification { get; set; }
        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [Required]
        public int BankAccount { get; set; }

    }

    public class EmpleadosDBContext : DBContext
    {
      public ISet<EmpleadoModel> Empleado { get; set; }
    }
}