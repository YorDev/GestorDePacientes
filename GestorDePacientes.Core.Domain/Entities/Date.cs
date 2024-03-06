using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDePacientes.Core.Domain.Entities
{
    public class Date
    {
        [Key]
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string Cause { get; set; }
        public string Satatus { get; set; }
        public int PatientDateId { get; set; }
        [ForeignKey("PatientDateId")]
        public virtual Patient Patient { get; set; }
    }
}
