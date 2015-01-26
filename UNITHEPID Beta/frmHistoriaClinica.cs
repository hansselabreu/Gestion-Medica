using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UNITHEPID_Beta
{
    public partial class frmHistoriaClinica : Form
    {
        public frmHistoriaClinica(Paciente _pacienteParam)
        {
            InitializeComponent();
            Paciente = _pacienteParam;
        }
        public Paciente Paciente { get; set; }
        public CapaNegocios.HistoriaClinica HistoriaClinica { get; set; }
        private void frmHistoriaClinica_Load(object sender, EventArgs e)
        {
            lblDatosPaciente.Text = string.Format("Id: {0} {1} {2} Edad: {3}",
                Paciente.Id, Paciente.Nombres, Paciente.Apellidos, Paciente.Edad);

        }

        private void btnVerDatosPaciente_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HistoriaClinica = CrearHistoriaClinica();
        }

        CapaNegocios.HistoriaClinica CrearHistoriaClinica()
        {
            CapaNegocios.HistoriaClinica _historia = new HistoriaClinica
            {
                IdPaciente = Paciente.Id,
                Sintomas = txtSignosYSintomas.Text,
                HistoriaEnfermedadActual = txtEnfermedadActual.Text,
                Hospitalarios = txtHospitalario.Text,
                Quirurgicos = txtQuirurgicos.Text,
                Traumaticos = txtTraumaticos.Text,
                Medicamentos = txtMedicamentos.Text,
                Alergicos = txtAlergicos.Text,
                Transfusionales = txtTransfusionales.Text,
                Virales = txtVirales.Text,
                Otros = txtOtros.Text
            };
            return _historia;
        }
    }
}
