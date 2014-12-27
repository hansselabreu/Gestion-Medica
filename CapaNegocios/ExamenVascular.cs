using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocios
{
    class ExamenVascular
    {
        public int IdPaciente { get; set; }

        public LADO Lado { get; set; }

        public byte PulsoPedio { get; set; }
        public byte TibialPosterior { get; set; }
        public byte Edema { get; set; }

        public ESTADO_EXAMEN RuborDependencia { get; set; }
        public ESTADO_EXAMEN PalidezElevacion { get; set; }

        public string ColoracionPiernaPie { get; set; }

        public ESTADO_EXAMEN FrialdadCutaneaPlantar { get; set; }

        public string IndiceTobilloBrazo { get; set; }
    }
}
