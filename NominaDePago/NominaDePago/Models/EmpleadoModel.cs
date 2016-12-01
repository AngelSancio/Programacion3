using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NominaDePago.Models
{
    public class EmpleadoModel
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Identification")]
        public int Identification { get; set; }
        [Required]
        [DisplayName("Phone Number")]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        [Required]
        [DisplayName("Address")]
        public string Address { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }
        [Required]
        [DisplayName("Bank Account")]
        public int BankAccount { get; set; }

    }

    public class EmpleadosDBContext : DBContext
    {
      public ISet<EmpleadoModel> Empleado { get; set; }
    }
}