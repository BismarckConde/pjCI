using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjCI
{
    public class Estudiante : Persona
    {
        public int CodigoEstudiante { get; set; }
        public List<Matricula> Matriculas { get; set; } = new List<Matricula>();

        public override string ToString()
        {
            return $"{CodigoEstudiante} - {Apellidos}";
        }
    }
}
