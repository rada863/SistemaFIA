using FIA_System.Models;
using System;
using System.Windows.Forms;
using proyecto2.Modelos;

namespace proyecto2.Forms
{
    public partial class PilotosForm : Form
    {
        private SistemaFIA _sistema;

        public PilotosForm(SistemaFIA sistema)
        {
            InitializeComponent();
            _sistema = sistema;

            
            cmbEquipo.DataSource = _sistema.Equipos;
            cmbEquipo.DisplayMember = "Nombre";
            cmbEquipo.ValueMember = "EquipoID";

            // muestra de licencia simuladas
            cmbLicencia.Items.AddRange(new string[]
            {
                "FIA123", "FIA456", "FIA789"
            });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            int edad = (int)numEdad.Value;
            string numeroLicencia = cmbLicencia.Text.Trim();
            DateTime? superLicencia = dtpSuperLicencia.Value;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(numeroLicencia))
            {
                MessageBox.Show("Por favor completá todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? equipoID = cmbEquipo.SelectedValue as int?;

            var piloto = _sistema.AgregarPiloto(nombre, edad, numeroLicencia, superLicencia);

            if (equipoID.HasValue)
                _sistema.AsignarPilotoAEquipo(piloto.PilotoID, equipoID.Value);

            MessageBox.Show("Piloto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}