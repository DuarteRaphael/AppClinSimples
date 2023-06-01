using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClinSimples.Entities
{
    public class Consulta
    {
        public Guid IdConsulta { get; set; }
        public DateTime DataConsulta { get; set; }
        public Medico medico { get; set; }
        public Paciente paciente { get; set; }
    }
}
