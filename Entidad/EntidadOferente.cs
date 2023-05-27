using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    internal class EntidadOferente
    {
        public string Identificacion { get; set; }
        public int CodTipoIdentificacion { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string LugardeRecidencia { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public byte Curriculum { get; set; }

       
    }
}
