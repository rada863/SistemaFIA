namespace proyecto2.Forms
{
    partial class ReportesForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.TextBox txtPorcentaje;

        private System.Windows.Forms.Label lblAutosPorEquipo;
        private System.Windows.Forms.ListBox lstAutosPorEquipo;

        private System.Windows.Forms.Button btnExportarCSV;
        private System.Windows.Forms.Button btnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblPorcentaje = new Label();
            txtPorcentaje = new TextBox();
            lblAutosPorEquipo = new Label();
            lstAutosPorEquipo = new ListBox();
            btnExportarCSV = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "📊 Reportes del Campeonato";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.Location = new Point(20, 80);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(200, 25);
            lblPorcentaje.TabIndex = 1;
            lblPorcentaje.Text = "Autos sin asignar (%):";
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(220, 78);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.ReadOnly = true;
            txtPorcentaje.Size = new Size(100, 31);
            txtPorcentaje.TabIndex = 2;
            // 
            // lblAutosPorEquipo
            // 
            lblAutosPorEquipo.Location = new Point(20, 120);
            lblAutosPorEquipo.Name = "lblAutosPorEquipo";
            lblAutosPorEquipo.Size = new Size(200, 25);
            lblAutosPorEquipo.TabIndex = 3;
            lblAutosPorEquipo.Text = "Autos por equipo:";
            // 
            // lstAutosPorEquipo
            // 
            lstAutosPorEquipo.ItemHeight = 25;
            lstAutosPorEquipo.Location = new Point(20, 150);
            lstAutosPorEquipo.Name = "lstAutosPorEquipo";
            lstAutosPorEquipo.Size = new Size(300, 179);
            lstAutosPorEquipo.TabIndex = 4;
            // 
            // btnExportarCSV
            // 
            btnExportarCSV.Location = new Point(20, 370);
            btnExportarCSV.Name = "btnExportarCSV";
            btnExportarCSV.Size = new Size(140, 35);
            btnExportarCSV.TabIndex = 5;
            btnExportarCSV.Text = "Exportar a CSV";
            btnExportarCSV.Click += btnExportarCSV_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(180, 370);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(140, 35);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // ReportesForm
            // 
            ClientSize = new Size(355, 430);
            Controls.Add(lblTitulo);
            Controls.Add(lblPorcentaje);
            Controls.Add(txtPorcentaje);
            Controls.Add(lblAutosPorEquipo);
            Controls.Add(lstAutosPorEquipo);
            Controls.Add(btnExportarCSV);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReportesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes FIA";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}