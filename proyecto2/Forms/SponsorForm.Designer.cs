namespace proyecto2.Forms
{
    partial class SponsorForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIndustria;
        private System.Windows.Forms.Label lblInversion;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIndustria;
        private System.Windows.Forms.NumericUpDown numInversion;

        private System.Windows.Forms.ListBox lstSponsorsDisponibles;

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblTitulo = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            lblIndustria = new System.Windows.Forms.Label();
            lblInversion = new System.Windows.Forms.Label();

            txtNombre = new System.Windows.Forms.TextBox();
            txtIndustria = new System.Windows.Forms.TextBox();
            numInversion = new System.Windows.Forms.NumericUpDown();

            lstSponsorsDisponibles = new System.Windows.Forms.ListBox();

            btnAgregar = new System.Windows.Forms.Button();
            btnCerrar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)numInversion).BeginInit();
            SuspendLayout();

            // Título
            lblTitulo.Text = "💼 Gestión de Sponsors";
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitulo.Location = new System.Drawing.Point(20, 20);
            lblTitulo.Size = new System.Drawing.Size(400, 35);
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Nombre
            lblNombre.Text = "Nombre:";
            lblNombre.Location = new System.Drawing.Point(30, 70);
            lblNombre.Size = new System.Drawing.Size(100, 25);

            txtNombre.Location = new System.Drawing.Point(140, 70);
            txtNombre.Size = new System.Drawing.Size(220, 27);

            // Industria
            lblIndustria.Text = "Industria:";
            lblIndustria.Location = new System.Drawing.Point(30, 110);
            lblIndustria.Size = new System.Drawing.Size(100, 25);

            txtIndustria.Location = new System.Drawing.Point(140, 110);
            txtIndustria.Size = new System.Drawing.Size(220, 27);

            // Inversión
            lblInversion.Text = "Inversión (USD):";
            lblInversion.Location = new System.Drawing.Point(30, 150);
            lblInversion.Size = new System.Drawing.Size(110, 25);

            numInversion.Location = new System.Drawing.Point(140, 150);
            numInversion.Maximum = 1000000000;
            numInversion.Minimum = 1000;
            numInversion.Increment = 10000;
            numInversion.Value = 100000;
            numInversion.Size = new System.Drawing.Size(220, 27);
            numInversion.ThousandsSeparator = true;

            // Botón Agregar
            btnAgregar.Text = "Agregar Sponsor";
            btnAgregar.Location = new System.Drawing.Point(30, 200);
            btnAgregar.Size = new System.Drawing.Size(160, 35);
            btnAgregar.Click += btnAgregar_Click;

            // Botón Cerrar
            btnCerrar.Text = "Cerrar";
            btnCerrar.Location = new System.Drawing.Point(200, 200);
            btnCerrar.Size = new System.Drawing.Size(160, 35);
            btnCerrar.Click += btnCerrar_Click;

            // Lista de sponsors disponibles
            lstSponsorsDisponibles.Location = new System.Drawing.Point(30, 260);
            lstSponsorsDisponibles.Size = new System.Drawing.Size(330, 150);

            // Formulario
            ClientSize = new System.Drawing.Size(400, 440);
            Controls.Add(lblTitulo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblIndustria);
            Controls.Add(txtIndustria);
            Controls.Add(lblInversion);
            Controls.Add(numInversion);
            Controls.Add(btnAgregar);
            Controls.Add(btnCerrar);
            Controls.Add(lstSponsorsDisponibles);

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sponsors";
            ((System.ComponentModel.ISupportInitialize)numInversion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}