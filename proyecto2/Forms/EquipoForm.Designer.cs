using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace proyecto2.Forms
{
    partial class EquiposForm 
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.DateTimePicker dtpFundacion;
        private System.Windows.Forms.Button btnAgregarEquipo;
        private System.Windows.Forms.Button btnEliminarEquipo;

        private System.Windows.Forms.ComboBox cmbSponsor;
        private System.Windows.Forms.Button btnAsignarSponsor;

        private System.Windows.Forms.ListBox IstPilotosDisponibles;
        private System.Windows.Forms.ListBox lstAutosDisponibles;
        private System.Windows.Forms.Button btnAsignarPiloto;
        private System.Windows.Forms.Button btnAsignarAuto;

        private System.Windows.Forms.TextBox txtDetalleNombre;
        private System.Windows.Forms.TextBox txtDetallePais;
        private System.Windows.Forms.TextBox txtDetalleFundacion;
        private System.Windows.Forms.TextBox txtDetalleSponsor;
        private System.Windows.Forms.ListBox lstPilotosAsignados;
        private System.Windows.Forms.ListBox lstAutosAsignados;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvEquipos = new DataGridView();
            txtNombre = new TextBox();
            txtPais = new TextBox();
            dtpFundacion = new DateTimePicker();
            btnAgregarEquipo = new Button();
            btnEliminarEquipo = new Button();
            cmbSponsor = new ComboBox();
            btnAsignarSponsor = new Button();
            IstPilotosDisponibles = new ListBox();
            lstAutosDisponibles = new ListBox();
            btnAsignarPiloto = new Button();
            btnAsignarAuto = new Button();
            txtDetalleNombre = new TextBox();
            txtDetallePais = new TextBox();
            txtDetalleFundacion = new TextBox();
            txtDetalleSponsor = new TextBox();
            lstPilotosAsignados = new ListBox();
            lstAutosAsignados = new ListBox();
            saveFileDialog1 = new SaveFileDialog();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeight = 34;
            dgvEquipos.Location = new Point(20, 20);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.RowHeadersWidth = 62;
            dgvEquipos.Size = new Size(600, 200);
            dgvEquipos.TabIndex = 0;
            dgvEquipos.SelectionChanged += dgvEquipos_SelectionChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(650, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 31);
            txtNombre.TabIndex = 1;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(650, 70);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(200, 31);
            txtPais.TabIndex = 2;
            // 
            // dtpFundacion
            // 
            dtpFundacion.Format = DateTimePickerFormat.Short;
            dtpFundacion.Location = new Point(650, 110);
            dtpFundacion.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dtpFundacion.MinDate = new DateTime(1800, 1, 1, 0, 0, 0, 0);
            dtpFundacion.Name = "dtpFundacion";
            dtpFundacion.Size = new Size(200, 31);
            dtpFundacion.TabIndex = 3;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.Location = new Point(650, 150);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(200, 30);
            btnAgregarEquipo.TabIndex = 4;
            btnAgregarEquipo.Text = "Agregar Equipo";
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.Location = new Point(650, 190);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(200, 30);
            btnEliminarEquipo.TabIndex = 5;
            btnEliminarEquipo.Text = "Eliminar Equipo";
            btnEliminarEquipo.Click += btnEliminarEquipo_Click;
            // 
            // cmbSponsor
            // 
            cmbSponsor.Location = new Point(20, 240);
            cmbSponsor.Name = "cmbSponsor";
            cmbSponsor.Size = new Size(200, 33);
            cmbSponsor.TabIndex = 6;
            // 
            // btnAsignarSponsor
            // 
            btnAsignarSponsor.Location = new Point(230, 240);
            btnAsignarSponsor.Name = "btnAsignarSponsor";
            btnAsignarSponsor.Size = new Size(220, 33);
            btnAsignarSponsor.TabIndex = 7;
            btnAsignarSponsor.Text = "Asignar Sponsor";
            btnAsignarSponsor.Click += btnAsignarSponsor_Click;
            // 
            // IstPilotosDisponibles
            // 
            IstPilotosDisponibles.ItemHeight = 25;
            IstPilotosDisponibles.Location = new Point(20, 290);
            IstPilotosDisponibles.Name = "IstPilotosDisponibles";
            IstPilotosDisponibles.Size = new Size(200, 79);
            IstPilotosDisponibles.TabIndex = 8;
            // 
            // lstAutosDisponibles
            // 
            lstAutosDisponibles.ItemHeight = 25;
            lstAutosDisponibles.Location = new Point(20, 400);
            lstAutosDisponibles.Name = "lstAutosDisponibles";
            lstAutosDisponibles.Size = new Size(200, 79);
            lstAutosDisponibles.TabIndex = 9;
            // 
            // btnAsignarPiloto
            // 
            btnAsignarPiloto.Location = new Point(230, 290);
            btnAsignarPiloto.Name = "btnAsignarPiloto";
            btnAsignarPiloto.Size = new Size(150, 30);
            btnAsignarPiloto.TabIndex = 10;
            btnAsignarPiloto.Text = "Asignar Piloto";
            btnAsignarPiloto.Click += btnAsignarPiloto_Click;
            // 
            // btnAsignarAuto
            // 
            btnAsignarAuto.Location = new Point(230, 400);
            btnAsignarAuto.Name = "btnAsignarAuto";
            btnAsignarAuto.Size = new Size(220, 48);
            btnAsignarAuto.TabIndex = 11;
            btnAsignarAuto.Text = "Asignar Auto";
            btnAsignarAuto.Click += btnAsignarAuto_Click;
            // 
            // txtDetalleNombre
            // 
            txtDetalleNombre.Location = new Point(637, 279);
            txtDetalleNombre.Name = "txtDetalleNombre";
            txtDetalleNombre.ReadOnly = true;
            txtDetalleNombre.Size = new Size(200, 31);
            txtDetalleNombre.TabIndex = 12;
            // 
            // txtDetallePais
            // 
            txtDetallePais.Location = new Point(637, 351);
            txtDetallePais.Name = "txtDetallePais";
            txtDetallePais.ReadOnly = true;
            txtDetallePais.Size = new Size(200, 31);
            txtDetallePais.TabIndex = 13;
            // 
            // txtDetalleFundacion
            // 
            txtDetalleFundacion.Location = new Point(637, 448);
            txtDetalleFundacion.Name = "txtDetalleFundacion";
            txtDetalleFundacion.ReadOnly = true;
            txtDetalleFundacion.Size = new Size(200, 31);
            txtDetalleFundacion.TabIndex = 14;
            // 
            // txtDetalleSponsor
            // 
            txtDetalleSponsor.Location = new Point(637, 553);
            txtDetalleSponsor.Name = "txtDetalleSponsor";
            txtDetalleSponsor.ReadOnly = true;
            txtDetalleSponsor.Size = new Size(200, 31);
            txtDetalleSponsor.TabIndex = 15;
            // 
            // lstPilotosAsignados
            // 
            lstPilotosAsignados.ItemHeight = 25;
            lstPilotosAsignados.Location = new Point(12, 505);
            lstPilotosAsignados.Name = "lstPilotosAsignados";
            lstPilotosAsignados.Size = new Size(200, 79);
            lstPilotosAsignados.TabIndex = 16;
            // 
            // lstAutosAsignados
            // 
            lstAutosAsignados.ItemHeight = 25;
            lstAutosAsignados.Location = new Point(278, 505);
            lstAutosAsignados.Name = "lstAutosAsignados";
            lstAutosAsignados.Size = new Size(200, 79);
            lstAutosAsignados.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(856, 73);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
            label1.TabIndex = 18;
            label1.Text = "Pais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(856, 36);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 19;
            label2.Text = "Nombre y apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(637, 505);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 20;
            label3.Text = "Detalle Sponsor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(639, 400);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 21;
            label4.Text = "Detalle Fundacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(674, 313);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 22;
            label5.Text = "Detalle Pais";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(674, 244);
            label6.Name = "label6";
            label6.Size = new Size(137, 25);
            label6.TabIndex = 23;
            label6.Text = "Detalle Nombre";
            // 
            // EquiposForm
            // 
            ClientSize = new Size(1084, 596);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEquipos);
            Controls.Add(txtNombre);
            Controls.Add(txtPais);
            Controls.Add(dtpFundacion);
            Controls.Add(btnAgregarEquipo);
            Controls.Add(btnEliminarEquipo);
            Controls.Add(cmbSponsor);
            Controls.Add(btnAsignarSponsor);
            Controls.Add(IstPilotosDisponibles);
            Controls.Add(lstAutosDisponibles);
            Controls.Add(btnAsignarPiloto);
            Controls.Add(btnAsignarAuto);
            Controls.Add(txtDetalleNombre);
            Controls.Add(txtDetallePais);
            Controls.Add(txtDetalleFundacion);
            Controls.Add(txtDetalleSponsor);
            Controls.Add(lstPilotosAsignados);
            Controls.Add(lstAutosAsignados);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "EquiposForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Equipos";
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}