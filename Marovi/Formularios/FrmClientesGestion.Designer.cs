
namespace Marovi.Formularios
{
    partial class FrmClientesGestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientesGestion));
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.ColIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbVerClientesActivos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CbActivo = new System.Windows.Forms.CheckBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIDCliente,
            this.ColCedula,
            this.ColNombre,
            this.ColCorreo});
            this.DgvLista.Location = new System.Drawing.Point(12, 81);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 51;
            this.DgvLista.RowTemplate.Height = 24;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(1011, 150);
            this.DgvLista.TabIndex = 0;
            this.DgvLista.VirtualMode = true;
            this.DgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLista_CellClick);
            
            // 
            // ColIDCliente
            // 
            this.ColIDCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColIDCliente.DataPropertyName = "IDCliente";
            this.ColIDCliente.HeaderText = "Código";
            this.ColIDCliente.MinimumWidth = 6;
            this.ColIDCliente.Name = "ColIDCliente";
            this.ColIDCliente.ReadOnly = true;
            this.ColIDCliente.Width = 80;
            // 
            // ColCedula
            // 
            this.ColCedula.DataPropertyName = "Cedula";
            this.ColCedula.HeaderText = "Cédula";
            this.ColCedula.MinimumWidth = 6;
            this.ColCedula.Name = "ColCedula";
            this.ColCedula.ReadOnly = true;
            this.ColCedula.Width = 125;
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombre.DataPropertyName = "Nombre";
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 6;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColCorreo
            // 
            this.ColCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColCorreo.DataPropertyName = "Correo";
            this.ColCorreo.HeaderText = "Email";
            this.ColCorreo.MinimumWidth = 6;
            this.ColCorreo.Name = "ColCorreo";
            this.ColCorreo.ReadOnly = true;
            this.ColCorreo.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(368, 31);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(300, 22);
            this.TxtBuscar.TabIndex = 2;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // CbVerClientesActivos
            // 
            this.CbVerClientesActivos.AutoSize = true;
            this.CbVerClientesActivos.Checked = true;
            this.CbVerClientesActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerClientesActivos.Location = new System.Drawing.Point(851, 33);
            this.CbVerClientesActivos.Name = "CbVerClientesActivos";
            this.CbVerClientesActivos.Size = new System.Drawing.Size(155, 21);
            this.CbVerClientesActivos.TabIndex = 3;
            this.CbVerClientesActivos.Text = "Ver Clientes Activos";
            this.CbVerClientesActivos.UseVisualStyleBackColor = true;
            this.CbVerClientesActivos.CheckedChanged += new System.EventHandler(this.CbVerClientesActivos_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.CbActivo);
            this.groupBox1.Controls.Add(this.TxtDireccion);
            this.groupBox1.Controls.Add(this.TxtCorreo);
            this.groupBox1.Controls.Add(this.TxtTelefono);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.TxtCedula);
            this.groupBox1.Controls.Add(this.TxtCod);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1011, 270);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(395, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(745, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(6, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "*";
            // 
            // CbActivo
            // 
            this.CbActivo.AutoSize = true;
            this.CbActivo.Location = new System.Drawing.Point(23, 213);
            this.CbActivo.Name = "CbActivo";
            this.CbActivo.Size = new System.Drawing.Size(68, 21);
            this.CbActivo.TabIndex = 11;
            this.CbActivo.Text = "Activo";
            this.CbActivo.UseVisualStyleBackColor = true;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(766, 157);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDireccion.Size = new System.Drawing.Size(228, 77);
            this.TxtDireccion.TabIndex = 10;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(766, 61);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(228, 22);
            this.TxtCorreo.TabIndex = 9;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(416, 157);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(228, 22);
            this.TxtTelefono.TabIndex = 8;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(416, 61);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(228, 22);
            this.TxtNombre.TabIndex = 7;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(23, 157);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(228, 22);
            this.TxtCedula.TabIndex = 6;
            // 
            // TxtCod
            // 
            this.TxtCod.Location = new System.Drawing.Point(23, 61);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.ReadOnly = true;
            this.TxtCod.Size = new System.Drawing.Size(228, 22);
            this.TxtCod.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(763, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(763, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Correo Electrónico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(25, 538);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(116, 42);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(107)))), ((int)(((byte)(139)))));
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(167, 538);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(107, 42);
            this.BtnEditar.TabIndex = 6;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(158)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(297, 538);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(111, 42);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(170)))), ((int)(((byte)(138)))));
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(641, 538);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(201, 42);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "Limpiar Formulario";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(177)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(876, 538);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(121, 42);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmClientesGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 592);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CbVerClientesActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvLista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClientesGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Clientes";
            this.Load += new System.EventHandler(this.FrmClientesGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CbVerClientesActivos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CbActivo;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtCod;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCorreo;
    }
}