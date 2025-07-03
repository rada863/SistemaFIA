namespace proyecto2.Forms
{
    partial class PilotosForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblNombre;
        private Label lblEdad;
        private Label lblNacionalidad;
        private Label lblEquipo;
        private Label lblLicencia;
        private TextBox txtNombre;
        private NumericUpDown numEdad;
        private ComboBox cmbNacionalidad;
        private ComboBox cmbEquipo;
        private ComboBox cmbLicencia;
        private DateTimePicker dtpSuperLicencia;
        private Button btnGuardar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            lblEdad = new Label();
            lblNacionalidad = new Label();
            lblEquipo = new Label();
            lblLicencia = new Label();
            txtNombre = new TextBox();
            numEdad = new NumericUpDown();
            cmbNacionalidad = new ComboBox();
            cmbEquipo = new ComboBox();
            cmbLicencia = new ComboBox();
            dtpSuperLicencia = new DateTimePicker();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            SuspendLayout();

            // lblTitulo
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🧑‍✈️ Gestión de Pilotos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // lblNombre
            lblNombre.Location = new Point(20, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";

            // txtNombre
            txtNombre.Location = new Point(130, 70);
            txtNombre.Size = new Size(250, 31);
            txtNombre.TabIndex = 2;

            // lblEdad
            lblEdad.Location = new Point(20, 110);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(100, 25);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad:";

            // numEdad
            numEdad.Location = new Point(130, 110);
            numEdad.Minimum = 18;
            numEdad.Maximum = 80;
            numEdad.Size = new Size(80, 31);
            numEdad.TabIndex = 4;
            numEdad.Value = 18;

            // lblNacionalidad
            lblNacionalidad.Location = new Point(20, 150);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(100, 25);
            lblNacionalidad.TabIndex = 5;
            lblNacionalidad.Text = "Nacionalidad:";

            // cmbNacionalidad
            cmbNacionalidad.Location = new Point(130, 150);
            cmbNacionalidad.Size = new Size(250, 33);
            cmbNacionalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNacionalidad.Items.AddRange(new object[] { "Argentina", "Brasil", "Italia", "España", "Japón" });
            cmbNacionalidad.TabIndex = 6;

            // lblEquipo
            lblEquipo.Location = new Point(20, 190);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(100, 25);
            lblEquipo.TabIndex = 7;
            lblEquipo.Text = "Equipo:";

            // cmbEquipo
            cmbEquipo.Location = new Point(130, 190);
            cmbEquipo.Size = new Size(250, 33);
            cmbEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipo.TabIndex = 8;

            // lblLicencia
            lblLicencia.Location = new Point(20, 230);
            lblLicencia.Name = "lblLicencia";
            lblLicencia.Size = new Size(100, 25);
            lblLicencia.TabIndex = 9;
            lblLicencia.Text = "Licencia ID:";

            // cmbLicencia
            cmbLicencia.Location = new Point(130, 230);
            cmbLicencia.Size = new Size(250, 33);
            cmbLicencia.TabIndex = 10;
            cmbLicencia.DropDownStyle = ComboBoxStyle.DropDown;

            // dtpSuperLicencia
            dtpSuperLicencia.Format = DateTimePickerFormat.Short;
            dtpSuperLicencia.Location = new Point(130, 270);
            dtpSuperLicencia.Size = new Size(250, 31);
            dtpSuperLicencia.TabIndex = 11;

            // btnGuardar
            btnGuardar.Text = "Guardar";
            btnGuardar.Location = new Point(60, 320);
            btnGuardar.Size = new Size(120, 35);
            btnGuardar.Click += btnGuardar_Click;
            btnGuardar.TabIndex = 12;

            // btnCancelar
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(200, 320);
            btnCancelar.Size = new Size(120, 35);
            btnCancelar.Click += btnCancelar_Click;
            btnCancelar.TabIndex = 13;

            // PilotosForm
            ClientSize = new Size(420, 390);
            Controls.Add(lblTitulo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblEdad);
            Controls.Add(numEdad);
            Controls.Add(lblNacionalidad);
            Controls.Add(cmbNacionalidad);
            Controls.Add(lblEquipo);
            Controls.Add(cmbEquipo);
            Controls.Add(lblLicencia);
            Controls.Add(cmbLicencia);
            Controls.Add(dtpSuperLicencia);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Pilotos";
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}