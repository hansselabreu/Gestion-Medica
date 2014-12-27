using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocios
{
    class PruebaComplementaria
    {
        public PruebaComplementaria(int idPaciente)
        {
            this.IdPaciente = idPaciente;
        }
        public int IdPaciente { get; set; }

        public Prueba Radiografia { get; set; }
        public Prueba Cultivo { get; set; }

        public Tratamiento Topico { get; set; }
        public Tratamiento Sistemico { get; set; }
        public Tratamiento Ortopodologico { get; set; }

        public string Observaciones { get; set; }

        public DateTime ProximoControl { get; set; }
        public bool ALTA { get; set; }
    }
    class Prueba
    {
        public bool Realizada { get; set; }
        public string Resultados { get; set; }
    }
    //class Radiografia : Prueba
    //{ }
    //class Cultivo : Prueba
    //{ }

    class Tratamiento
    {
        public string Descripcion { get; set; }
        public string Pauta { get; set; }
    }
    //class Topico : Tratamiento { }
    //class Sistemico : Tratamiento { }
    //class Ortopodologico : Tratamiento { }

}
