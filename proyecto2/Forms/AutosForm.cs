using System;
using System.Windows.Forms;
using proyecto2.Modelos;

namespace proyecto2.Forms
{
    public partial class AutoForm : Form
    {
        private readonly SistemaFIA _sistema;

        public AutoForm(SistemaFIA sistema)
        {
            InitializeComponent();
            _sistema = sistema;

            // Cargar enums en los comboBox
            cmbCategoria.DataSource = Enum.GetValues(typeof(CategoriaAuto));
            cmbUnidadPotencia.DataSource = Enum.GetValues(typeof(UnidadPotencia));
            cmbDRS.DataSource = Enum.GetValues(typeof(DRSType));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string modelo = txtModelo.Text.Trim();
            if (string.IsNullOrWhiteSpace(modelo))
            {
                MessageBox.Show("Por favor ingresá el modelo del auto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener valores seleccionados
            var categoria = (CategoriaAuto)cmbCategoria.SelectedItem;
            var unidad = (UnidadPotencia)cmbUnidadPotencia.SelectedItem;
            var drs = (DRSType)cmbDRS.SelectedItem;
            bool tieneHalo = chkHALO.Checked;

            try
            {
                _sistema.AgregarAuto(modelo, categoria, unidad.ToString(), drs, tieneHalo);
                MessageBox.Show("Auto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar auto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}