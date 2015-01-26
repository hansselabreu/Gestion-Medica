using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocios
{
    public class HistoriaClinica:ISearchable
    {
        public int Id { get; set; }
        /// <summary>
        /// Id del paciente con esta historia clínica
        /// </summary>
        public int IdPaciente { get; set; }

        public string Sintomas { get; set; }
        public string HistoriaEnfermedadActual { get; set; }

        #region ANTECEDENTES PATOLÓGICOS PERSONALES

        public string Hospitalarios { get; set; }
        public string Quirurgicos { get; set; }
        public string Traumaticos { get; set; }
        public string Medicamentos { get; set; }
        public string Alergicos { get; set; }
        public string Transfusionales { get; set; }
        public string Virales { get; set; }
        public string Otros { get; set; }

        #endregion


        #region ANTECEDENTES FAMILIARES

        public string Padre { get; set; }
        public string Madre { get; set; }
        public string Hermanos { get; set; }
        public string Hijos { get; set; }

        #endregion


        #region HÁBITOS TÓXICOS

        public string Cafe { get; set; }
        public string Tabaco { get; set; }
        public string Alcohol { get; set; }
        public string Tisanas { get; set; }
        public string Drogas { get; set; }

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
