using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocios
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public ESTADOCIVIL EstadoCivil { get; set; }
        public SEXO Sexo { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public NIVELESCOLAR NivelEscolar { get; set; }


    }
}
