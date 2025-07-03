using System;
using System.Windows.Forms;
using proyecto2.Modelos;

namespace proyecto2.Forms
{
    public partial class MainForm : Form
    {
        private readonly SistemaFIA _sistema;

        public MainForm(SistemaFIA sistema)
        {
            InitializeComponent();
            _sistema = sistema;
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            new EquiposForm(_sistema).ShowDialog();
        }

        private void btnPiloto_Click(object sender, EventArgs e)
        {
            new PilotosForm(_sistema).ShowDialog();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            new AutoForm(_sistema).ShowDialog();
        }

        private void btnSponsor_Click(object sender, EventArgs e)
        {
            new SponsorForm(_sistema).ShowDialog();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            new ReportesForm(_sistema).ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}