using System;
using System.Linq;
using System.Windows.Forms;
using proyecto2.Modelos;

namespace proyecto2.Forms
{
    public partial class EquiposForm : Form
    {
        private readonly SistemaFIA _sistema;

        public EquiposForm(SistemaFIA sistema)
        {
            InitializeComponent();
            _sistema = sistema;

            CargarEquipos();
            CargarSponsorsDisponibles();
            CargarPilotosDisponibles();
            CargarAutosDisponibles();
        }

        private void CargarEquipos()
        {
            // Asegurarse de que haya columnas antes de agregar filas
            if (dgvEquipos.Columns.Count == 0)
            {
                dgvEquipos.Columns.Add("ID", "ID");
                dgvEquipos.Columns.Add("Nombre", "Nombre");
                dgvEquipos.Columns.Add("Pais", "País");
                dgvEquipos.Columns.Add("Fundacion", "Año de Fundación");
                dgvEquipos.Columns.Add("Sponsor", "Sponsor Principal");
                dgvEquipos.Columns.Add("CantidadPilotos", "Pilotos");
                dgvEquipos.Columns.Add("CantidadAutos", "Autos");
            }

            dgvEquipos.Rows.Clear();
            foreach (var equipo in _sistema.Equipos)
            {
                dgvEquipos.Rows.Add(
                    equipo.EquipoID,
                    equipo.Nombre,
                    equipo.Pais,
                    equipo.Fundacion.ToShortDateString(),
                    equipo.SponsorPrincipal?.Nombre ?? "Sin sponsor",
                    equipo.Pilotos.Count,
                    equipo.Autos.Count
                );
            }
        }

        private void CargarSponsorsDisponibles()
        {
            cmbSponsor.Items.Clear();
            cmbSponsor.Items.Add("-- Seleccione --");
            foreach (var sponsor in _sistema.Sponsors.Where(s => !s.EquipoID.HasValue))
            {
                cmbSponsor.Items.Add(sponsor.Nombre);
            }
            cmbSponsor.SelectedIndex = 0;
        }

        private void CargarPilotosDisponibles()
        {
            IstPilotosDisponibles.Items.Clear();
            foreach (var piloto in _sistema.Pilotos.Where(p => !p.EquipoID.HasValue))
            {
                IstPilotosDisponibles.Items.Add($"{piloto.Nombre} ({piloto.NumeroLicencia})");
            }
        }

        private void CargarAutosDisponibles()
        {
            lstAutosDisponibles.Items.Clear();
            foreach (var auto in _sistema.Autos.Where(a => !a.EquipoID.HasValue))
            {
                lstAutosDisponibles.Items.Add($"{auto.AutoID} - {auto.Modelo}");
            }
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPais.Text))
            {
                MessageBox.Show("Nombre y país son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _sistema.AgregarEquipo(txtNombre.Text.Trim(), txtPais.Text.Trim(), dtpFundacion.Value);
                MessageBox.Show("Equipo agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEquipos();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar equipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtPais.Clear();
            dtpFundacion.Value = DateTime.Today;
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count == 0) return;

            int equipoID = (int)dgvEquipos.SelectedRows[0].Cells[0].Value;
            string nombre = dgvEquipos.SelectedRows[0].Cells[1].Value.ToString();

            if (MessageBox.Show($"¿Eliminar el equipo {nombre}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_sistema.EliminarEquipo(equipoID))
                {
                    MessageBox.Show("Equipo eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEquipos();
                    CargarSponsorsDisponibles();
                    CargarPilotosDisponibles();
                    CargarAutosDisponibles();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvEquipos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count == 0) return;

            int equipoID = (int)dgvEquipos.SelectedRows[0].Cells[0].Value;
            var equipo = _sistema.Equipos.FirstOrDefault(e => e.EquipoID == equipoID);
            if (equipo == null) return;

            txtDetalleNombre.Text = equipo.Nombre;
            txtDetallePais.Text = equipo.Pais;
            txtDetalleFundacion.Text = equipo.Fundacion.ToShortDateString();
            txtDetalleSponsor.Text = equipo.SponsorPrincipal?.Nombre ?? "Sin sponsor";

            lstPilotosAsignados.Items.Clear();
            foreach (var p in equipo.Pilotos)
                lstPilotosAsignados.Items.Add($"{p.Nombre} ({p.NumeroLicencia})");

            lstAutosAsignados.Items.Clear();
            foreach (var a in equipo.Autos)
                lstAutosAsignados.Items.Add($"{a.AutoID} - {a.Modelo}");

            btnAsignarSponsor.Enabled = cmbSponsor.Items.Count > 1;
            btnAsignarPiloto.Enabled = IstPilotosDisponibles.Items.Count > 0 && equipo.Pilotos.Count < 4;
            btnAsignarAuto.Enabled = lstAutosDisponibles.Items.Count > 0 && equipo.Autos.Count < 2;
        }

        private void btnAsignarSponsor_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count == 0 || cmbSponsor.SelectedIndex <= 0) return;

            int equipoID = (int)dgvEquipos.SelectedRows[0].Cells[0].Value;
            string sponsorNombre = cmbSponsor.SelectedItem.ToString();
            var sponsor = _sistema.Sponsors.FirstOrDefault(s => s.Nombre == sponsorNombre);

            if (sponsor != null && _sistema.AsignarSponsorAEquipo(sponsor.SponsorID, equipoID))
            {
                MessageBox.Show("Sponsor asignado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEquipos();
                CargarSponsorsDisponibles();
            }
            else
            {
                MessageBox.Show("No se pudo asignar el sponsor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsignarPiloto_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count == 0 || IstPilotosDisponibles.SelectedIndex == -1) return;

            int equipoID = (int)dgvEquipos.SelectedRows[0].Cells[0].Value;
            string pilotoInfo = IstPilotosDisponibles.SelectedItem.ToString();
            string licencia = pilotoInfo.Split('(', ')')[1];
            var piloto = _sistema.Pilotos.FirstOrDefault(p => p.NumeroLicencia == licencia);

            if (piloto != null && _sistema.AsignarPilotoAEquipo(piloto.PilotoID, equipoID))
            {
                MessageBox.Show("Piloto asignado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEquipos();
                CargarPilotosDisponibles();
            }
            else
            {
                MessageBox.Show("No se pudo asignar el piloto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsignarAuto_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count == 0 || lstAutosDisponibles.SelectedIndex == -1) return;

            int equipoID = (int)dgvEquipos.SelectedRows[0].Cells[0].Value;
            string autoInfo = lstAutosDisponibles.SelectedItem.ToString();
            int autoID = int.Parse(autoInfo.Split('-')[0].Trim());
            var auto = _sistema.Autos.FirstOrDefault(a => a.AutoID == autoID);

            if (auto != null && _sistema.AsignarAutoAEquipo(auto.AutoID, equipoID))
            {
                MessageBox.Show("Auto asignado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEquipos();
                CargarAutosDisponibles();
            }
            else
            {
                MessageBox.Show("No se pudo asignar el auto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}