using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace proyecto2.Forms
{
    partial class AutoForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblUnidadPotencia;
        private System.Windows.Forms.Label lblDRS;
        private System.Windows.Forms.Label lblHALO;

        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbUnidadPotencia;
        private System.Windows.Forms.ComboBox cmbDRS;
        private System.Windows.Forms.CheckBox chkHALO;

        private System.Windows.Forms.Button btnGuardar;
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
            lblModelo = new Label();
            lblCategoria = new Label();
            lblUnidadPotencia = new Label();
            lblDRS = new Label();
            lblHALO = new Label();
            txtModelo = new TextBox();
            cmbCategoria = new ComboBox();
            cmbUnidadPotencia = new ComboBox();
            cmbDRS = new ComboBox();
            chkHALO = new CheckBox();
            btnGuardar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(360, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🚗 Registro de Autos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblModelo
            // 
            lblModelo.Location = new Point(30, 70);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(84, 31);
            lblModelo.TabIndex = 1;
            lblModelo.Text = "Modelo:";
            // 
            // lblCategoria
            // 
            lblCategoria.Location = new Point(30, 110);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(100, 30);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoría:";
            // 
            // lblUnidadPotencia
            // 
            lblUnidadPotencia.Location = new Point(30, 150);
            lblUnidadPotencia.Name = "lblUnidadPotencia";
            lblUnidadPotencia.Size = new Size(155, 30);
            lblUnidadPotencia.TabIndex = 5;
            lblUnidadPotencia.Text = "Unidad Potencia:";
            // 
            // lblDRS
            // 
            lblDRS.Location = new Point(30, 190);
            lblDRS.Name = "lblDRS";
            lblDRS.Size = new Size(155, 33);
            lblDRS.TabIndex = 7;
            lblDRS.Text = "Sistema DRS:";
            // 
            // lblHALO
            // 
            lblHALO.Location = new Point(30, 230);
            lblHALO.Name = "lblHALO";
            lblHALO.Size = new Size(129, 24);
            lblHALO.TabIndex = 9;
            lblHALO.Text = "Tiene HALO:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(227, 70);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(200, 31);
            txtModelo.TabIndex = 2;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Location = new Point(227, 107);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(200, 33);
            cmbCategoria.TabIndex = 4;
            // 
            // cmbUnidadPotencia
            // 
            cmbUnidadPotencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnidadPotencia.Location = new Point(227, 147);
            cmbUnidadPotencia.Name = "cmbUnidadPotencia";
            cmbUnidadPotencia.Size = new Size(200, 33);
            cmbUnidadPotencia.TabIndex = 6;
            // 
            // cmbDRS
            // 
            cmbDRS.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDRS.Location = new Point(227, 190);
            cmbDRS.Name = "cmbDRS";
            cmbDRS.Size = new Size(200, 33);
            cmbDRS.TabIndex = 8;
            // 
            // chkHALO
            // 
            chkHALO.Location = new Point(182, 229);
            chkHALO.Name = "chkHALO";
            chkHALO.Size = new Size(21, 25);
            chkHALO.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(50, 280);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 35);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(200, 280);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(120, 35);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // AutoForm
            // 
            ClientSize = new Size(548, 427);
            Controls.Add(lblTitulo);
            Controls.Add(lblModelo);
            Controls.Add(txtModelo);
            Controls.Add(lblCategoria);
            Controls.Add(cmbCategoria);
            Controls.Add(lblUnidadPotencia);
            Controls.Add(cmbUnidadPotencia);
            Controls.Add(lblDRS);
            Controls.Add(cmbDRS);
            Controls.Add(lblHALO);
            Controls.Add(chkHALO);
            Controls.Add(btnGuardar);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AutoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Autos";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}