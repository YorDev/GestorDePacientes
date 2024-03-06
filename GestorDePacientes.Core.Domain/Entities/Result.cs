using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDePacientes.Core.Domain.Entities
{
    public class Result
    {
        public int Id { get; set; }
        public virtual Patient Patient { get; set; }
        public int TestId { get; set; }
        [ForeignKey("TestId")]
        public virtual Test Test { get; set; }

    }
}
