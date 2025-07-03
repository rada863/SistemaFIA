namespace proyecto2.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Button btnEquipos;
        private Button btnAuto;
        private Button btnPiloto;
        private Button btnReporte;
        private Button btnSponsor;
        private Button btnSalir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnEquipos = new Button();
            btnAuto = new Button();
            btnPiloto = new Button();
            btnReporte = new Button();
            btnSponsor = new Button();
            btnSalir = new Button();
            SuspendLayout();

            // lblTitulo
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Navy;
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(580, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🏁 Gestión del Campeonato";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // btnEquipos
            btnEquipos.Location = new Point(80, 80);
            btnEquipos.Name = "btnEquipos";
            btnEquipos.Size = new Size(480, 40);
            btnEquipos.TabIndex = 1;
            btnEquipos.Text = "Equipos";
            btnEquipos.Click += btnEquipos_Click;

            // btnPiloto
            btnPiloto.Location = new Point(80, 130);
            btnPiloto.Name = "btnPiloto";
            btnPiloto.Size = new Size(480, 40);
            btnPiloto.TabIndex = 2;
            btnPiloto.Text = "Pilotos";
            btnPiloto.Click += btnPiloto_Click;

            // btnAuto
            btnAuto.Location = new Point(80, 180);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(480, 40);
            btnAuto.TabIndex = 3;
            btnAuto.Text = "Autos";
            btnAuto.Click += btnAuto_Click;

            // btnSponsor
            btnSponsor.Location = new Point(80, 230);
            btnSponsor.Name = "btnSponsor";
            btnSponsor.Size = new Size(480, 40);
            btnSponsor.TabIndex = 4;
            btnSponsor.Text = "Sponsors";
            btnSponsor.Click += btnSponsor_Click;

            // btnReporte
            btnReporte.Location = new Point(80, 280);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(480, 40);
            btnReporte.TabIndex = 5;
            btnReporte.Text = "Reportes";
            btnReporte.Click += btnReporte_Click;

            // btnSalir
            btnSalir.Location = new Point(80, 330);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(480, 40);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;

            // MainForm
            ClientSize = new Size(640, 420);
            Controls.Add(lblTitulo);
            Controls.Add(btnEquipos);
            Controls.Add(btnPiloto);
            Controls.Add(btnAuto);
            Controls.Add(btnSponsor);
            Controls.Add(btnReporte);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema FIA";
            ResumeLayout(false);
        }
    }
}