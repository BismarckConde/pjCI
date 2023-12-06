using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjCI
{
    public class Profesor : Persona
    {
        public int CodigoProfesor { get; set; }
        public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
    }
}
