using AccesoDatos;
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
    public partial class frmNuevoPaciente : Form
    {
        public frmNuevoPaciente()
        {
            InitializeComponent();
            _contextDb = new Database();
        }
        Paciente _pacienteNuevo;
        Database _contextDb;

        private void pbFoto_DoubleClick(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imágenes (*.jpg, *.png, *.bmp)|*.png;*.gif;*.bmp";
                var result = ofd.ShowDialog();
                if(result == DialogResult.OK)
                {
                    pbFoto.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _pacienteNuevo = NuevoPaciente();
            _contextDb.Pacientes.Add(_pacienteNuevo);
            try
            {   
                _contextDb.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Paciente NuevoPaciente()
        {
            NIVELESCOLAR nivel;
            Enum.TryParse<NIVELESCOLAR>(cboNivelEscolar.SelectedValue.ToString(), out nivel);
            var nuevoPaciente = new Paciente
            {
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Sexo = (radioMasculino.Checked) ? SEXO.Masculino : SEXO.Femenino,
                EstadoCivil = comprobarEstadoCivil(),
                Nacionalidad = txtProcedencia.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                NivelEscolar = nivel,
                Cedula = txtCedula.Text
            };
            return nuevoPaciente;
        }
        ESTADOCIVIL comprobarEstadoCivil()
        {
            ESTADOCIVIL nuevoEstadoCivil = ESTADOCIVIL.Soltero;

            if (radioViudo.Checked)
                nuevoEstadoCivil = ESTADOCIVIL.Viudo;
            if (radioCasado.Checked)
                nuevoEstadoCivil = ESTADOCIVIL.Casado;
            if (radioUnionLibre.Checked)
                nuevoEstadoCivil = ESTADOCIVIL.UnionLibre;

            return nuevoEstadoCivil;
        }

        private void frmNuevoPaciente_Load(object sender, EventArgs e)
        {
            CargarNivelesEscolares();

        }

        void CargarNivelesEscolares()
        {
            cboNivelEscolar.DataSource = Enum.GetValues(typeof(NIVELESCOLAR));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
