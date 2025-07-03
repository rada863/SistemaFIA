using System;
using System.Linq;
using System.Windows.Forms;
using proyecto2.Modelos;

namespace proyecto2.Forms
{
    public partial class SponsorForm : Form
    {
        private readonly SistemaFIA _sistema;

        public SponsorForm(SistemaFIA sistema)
        {
            InitializeComponent();
            _sistema = sistema;
            CargarSponsorsDisponibles();
        }

        private void CargarSponsorsDisponibles()
        {
            lstSponsorsDisponibles.Items.Clear();

            foreach (var sponsor in _sistema.Sponsors.Where(s => !s.EquipoID.HasValue))
            {
                lstSponsorsDisponibles.Items.Add($"{sponsor.Nombre} - {sponsor.Industria} (${sponsor.Inversion:N0})");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string industria = txtIndustria.Text.Trim();
            decimal inversion = numInversion.Value;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(industria))
            {
                MessageBox.Show("Por favor completá todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _sistema.AgregarSponsor(nombre, industria, inversion);
                MessageBox.Show("Sponsor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                txtIndustria.Clear();
                numInversion.Value = 100000;
                CargarSponsorsDisponibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar sponsor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}