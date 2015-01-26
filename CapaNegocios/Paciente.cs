using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CapaNegocios
{
    public class Paciente:ISearchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public ESTADOCIVIL EstadoCivil { get; set; }
        public SEXO Sexo { get; set; }
        public byte Edad { get; set; }
        [MaxLength(50)]
        public string Nacionalidad { get; set; }
        public string Direccion { get; set; }
        [MaxLength(12)]
        public string Telefono { get; set; }
        [MaxLength(13)]
        public string Cedula { get; set; }
        public NIVELESCOLAR NivelEscolar { get; set; }
        public string RutaFoto { get; set; }

    }
}
