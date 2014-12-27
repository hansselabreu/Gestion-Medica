using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocios
{
    public class HistoriaClinica
    {
        /// <summary>
        /// Id del paciente con esta historia clínica
        /// </summary>
        public int IdPaciente { get; set; }

        public string Sintomas { get; set; }
        public string HistoriaEnfermedadActual { get; set; }

        #region ANTECEDENTES PATOLÓGICOS PERSONALES

        public AntecedentePatologico Hospitalarios { get; set; }
        public AntecedentePatologico Quirurgicos { get; set; }
        public AntecedentePatologico Traumaticos { get; set; }
        public AntecedentePatologico Medicamentos { get; set; }
        public AntecedentePatologico Alergicos { get; set; }
        public AntecedentePatologico Transfusionales { get; set; }
        public AntecedentePatologico Virales { get; set; }
        public AntecedentePatologico Otros { get; set; }

        #endregion


        #region ANTECEDENTES FAMILIARES

        public AntecedentePatologico Padre { get; set; }
        public AntecedentePatologico Madre { get; set; }
        public AntecedentePatologico Hermanos { get; set; }
        public AntecedentePatologico Hijos { get; set; }

        #endregion


        #region HÁBITOS TÓXICOS

        public AntecedentePatologico Cafe { get; set; }
        public AntecedentePatologico Tabaco { get; set; }
        public AntecedentePatologico Alcohol { get; set; }
        public AntecedentePatologico Tisanas { get; set; }
        public AntecedentePatologico Drogas { get; set; }

        #endregion


        #region REVISION POR SISTEMAS

        public Revision SistemaNerviosoCentral { get; set; }
        public Revision SistemaRespiratorio { get; set; }
        public Revision SistemaCardiovascular { get; set; }
        public Revision SistemaUrinario { get; set; }
        public Revision SistemaEndrocrinoMetabolico { get; set; }
        public Revision SistemaEsqueletico { get; set; }
        public Revision SistemaGastrointestinal { get; set; }

        #endregion

        //EXAMEN FISICO
        public ExamenFisicoTA TA { get; set; }
        public ExamenFisico FA { get; set; }
        public ExamenFisico FR { get; set; }

        //Atributos del paciente
        public float Peso { get; set; }
        public float Estatura { get; set; }
        public float IMC { get; set; }

        //Observaciones
        public Dictionary<string, string> PartesDelCuerpo;

        //Estudio de imagenes
        public Dictionary<string,string> EstudioImagenes { get; set; }

        //Pendientes
        public string Pendientes { get; set; }

        public HistoriaClinica()
        {
            PartesDelCuerpo = new Dictionary<string, string>()
            {
                {"Cabeza", ""}, {"Ojos", ""},{"Nariz", ""},{"Oidos", ""},{"Boca", ""},
                {"Cuello", ""},{"Torax", ""},{"Mamas", ""},{"Corazon", ""},{"Pulmones", ""},
                {"Abdomen", ""}, {"GenitalesExternos", ""},{"TactoVaginal", ""},{"TactoRectal", ""},
                {"ExtremidadesSuperiores", ""},{"ExtremidadesInferiores", ""},{"PielYTegumentos", ""},
                {"ExamenNeurologico", ""}
            };

            PruebasLaboratorio = new Dictionary<string, string>()
            {
                {"Hemograma",""}, {"Tipificacion",""}, {"Glicemia",""}, {"Urea",""}, {"Creatinina",""},
                {"TP",""}, {"TPT",""}, {"ALT",""}, {"AST",""}, {"FA",""}, {"Bil",""}, {"Prot",""},
                {"Elect",""}, {"ExOrina",""}, {"HBA1C",""}, {"HVC",""}, {"PerfLipidico",""}, {"Otros",""}
            };


            EstudioImagenes = new Dictionary<string, string>()
            {
                {"Radiografia",""}, {"TAC",""}, {"RNM",""}, {"Sonografia",""}, {"Doppler",""},
                {"Arteriografia",""}, {"EKG",""}, {"Otros",""}
            };
        }

        public string DiagnosticoImpresion { get; set; }
        public string Plan { get; set; }

        public Dictionary<string,string> PruebasLaboratorio { get; set; }
    }

    public class AntecedentePatologico
    {
        public string Detalles { get; set; }
    }

    public class Revision
    {
        public string Detalles { get; set; }
    }

    public class ExamenFisico
    {
        public float Valor { get; set; }
        public string Unidad { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Valor, Unidad);
        }
    }
    public class ExamenFisicoTA
    {
        public string Valor { get; set; }

        public override string ToString()
        {
            return string.Format("{0} mmhg", Valor);
        }
    }
}
