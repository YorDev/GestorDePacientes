using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDePacientes.Core.Domain.Entities
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string IdCard { get; set; }
        public string BirdthDay { get; set; }
        public bool smooker { get; set; }
        public bool allergy { get; set; }
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public virtual Doctor Doctor { get; set; }
        public virtual ICollection<Result> Results { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
        public virtual ICollection<Date> Dates { get; set; }

    }
}
