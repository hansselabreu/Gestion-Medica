using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocios
{
    class ExamenNeurologico
    {
        public int IdPaciente { get; set; }

        public LADO Lado { get; set; }

        public ESTADO_EXAMEN ReflejoPaletar { get; set; }
        public ESTADO_EXAMEN ReflejoAquileo { get; set; }
        public ESTADO_EXAMEN SensibilidadTactil { get; set; }
        public ESTADO_EXAMEN SensibilidadVibratoria { get; set; }

    }
}
