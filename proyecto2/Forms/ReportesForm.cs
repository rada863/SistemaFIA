using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using proyecto2.Modelos;

namespace proyecto2.Forms
{
    public partial class ReportesForm : Form
    {
        private readonly SistemaFIA _sistema;

        public ReportesForm(SistemaFIA sistema)
        {
            InitializeComponent();
            _sistema = sistema;

            MostrarPorcentajeAutosSinAsignar();
            MostrarAutosPorEquipo();
        }

        private void MostrarPorcentajeAutosSinAsignar()
        {
            decimal porcentaje = _sistema.PorcentajeAutosSinAsignar();
            txtPorcentaje.Text = $"{porcentaje:F2}%";
        }

        private void MostrarAutosPorEquipo()
        {
            lstAutosPorEquipo.Items.Clear();
            Dictionary<string, int> autosPorEquipo = _sistema.AutosPorEquipo();

            foreach (var kvp in autosPorEquipo)
            {
                lstAutosPorEquipo.Items.Add($"{kvp.Key}: {kvp.Value} auto(s)");
            }
        }

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            try
            {
                using SaveFileDialog sfd = new SaveFileDialog
                {
                    Title = "Guardar reporte",
                    Filter = "CSV Files (*.csv)|*.csv",
                    FileName = "reporte_fia.csv"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8);
                    writer.WriteLine("Equipo,Autos");

                    var datos = _sistema.AutosPorEquipo();
                    foreach (var kvp in datos)
                    {
                        writer.WriteLine($"{kvp.Key},{kvp.Value}");
                    }

                    MessageBox.Show("Reporte exportado exitosamente.", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}