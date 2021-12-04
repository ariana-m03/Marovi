
namespace Marovi.Formularios
{
    partial class FrmRutasGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRutasGestion));
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbVerRutasActivas = new System.Windows.Forms.CheckBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.CIDRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CParadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadParadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtParadas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtDistrito = new System.Windows.Forms.TextBox();
            this.TxtCanton = new System.Windows.Forms.TextBox();
            this.TxtProvincia = new System.Windows.Forms.TextBox();
            this.CboxUsuario = new System.Windows.Forms.ComboBox();
            this.TxtTransporte = new System.Windows.Forms.TextBox();
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.CbActivo = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
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
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(375, 30);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(300, 22);
            this.TxtBuscar.TabIndex = 0;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // CbVerRutasActivas
            // 
            this.CbVerRutasActivas.AutoSize = true;
            this.CbVerRutasActivas.Checked = true;
            this.CbVerRutasActivas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerRutasActivas.Location = new System.Drawing.Point(858, 32);
            this.CbVerRutasActivas.Name = "CbVerRutasActivas";
            this.CbVerRutasActivas.Size = new System.Drawing.Size(142, 21);
            this.CbVerRutasActivas.TabIndex = 2;
            this.CbVerRutasActivas.Text = "Ver Rutas Activas";
            this.CbVerRutasActivas.UseVisualStyleBackColor = true;
            this.CbVerRutasActivas.CheckedChanged += new System.EventHandler(this.CbRutasActivas_CheckedChanged);
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDRuta,
            this.CParadas,
            this.CTransporte,
            this.CCantidadParadas});
            this.DgvLista.Location = new System.Drawing.Point(12, 75);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 51;
            this.DgvLista.RowTemplate.Height = 24;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(1007, 150);
            this.DgvLista.TabIndex = 3;
            this.DgvLista.VirtualMode = true;
            this.DgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLista_CellClick);
            // 
            // CIDRuta
            // 
            this.CIDRuta.DataPropertyName = "IDRuta";
            this.CIDRuta.HeaderText = "Código";
            this.CIDRuta.MinimumWidth = 6;
            this.CIDRuta.Name = "CIDRuta";
            this.CIDRuta.Width = 125;
            // 
            // CParadas
            // 
            this.CParadas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CParadas.DataPropertyName = "Paradas";
            this.CParadas.HeaderText = "Paradas";
            this.CParadas.MinimumWidth = 6;
            this.CParadas.Name = "CParadas";
            // 
            // CTransporte
            // 
            this.CTransporte.DataPropertyName = "TipoTransporte";
            this.CTransporte.HeaderText = "Transporte";
            this.CTransporte.MinimumWidth = 6;
            this.CTransporte.Name = "CTransporte";
            this.CTransporte.Width = 125;
            // 
            // CCantidadParadas
            // 
            this.CCantidadParadas.DataPropertyName = "CantidadParadas";
            this.CCantidadParadas.HeaderText = "Cantidad Paradas";
            this.CCantidadParadas.MinimumWidth = 6;
            this.CCantidadParadas.Name = "CCantidadParadas";
            this.CCantidadParadas.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtParadas);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtCantidad);
            this.groupBox1.Controls.Add(this.TxtDistrito);
            this.groupBox1.Controls.Add(this.TxtCanton);
            this.groupBox1.Controls.Add(this.TxtProvincia);
            this.groupBox1.Controls.Add(this.CboxUsuario);
            this.groupBox1.Controls.Add(this.TxtTransporte);
            this.groupBox1.Controls.Add(this.TxtCod);
            this.groupBox1.Controls.Add(this.CbActivo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 295);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // TxtParadas
            // 
            this.TxtParadas.Location = new System.Drawing.Point(754, 149);
            this.TxtParadas.Multiline = true;
            this.TxtParadas.Name = "TxtParadas";
            this.TxtParadas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtParadas.Size = new System.Drawing.Size(221, 91);
            this.TxtParadas.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(751, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Paradas";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(754, 72);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(221, 22);
            this.TxtCantidad.TabIndex = 14;
            // 
            // TxtDistrito
            // 
            this.TxtDistrito.Location = new System.Drawing.Point(416, 231);
            this.TxtDistrito.Name = "TxtDistrito";
            this.TxtDistrito.Size = new System.Drawing.Size(228, 22);
            this.TxtDistrito.TabIndex = 13;
            // 
            // TxtCanton
            // 
            this.TxtCanton.Location = new System.Drawing.Point(416, 149);
            this.TxtCanton.Name = "TxtCanton";
            this.TxtCanton.Size = new System.Drawing.Size(228, 22);
            this.TxtCanton.TabIndex = 12;
            // 
            // TxtProvincia
            // 
            this.TxtProvincia.Location = new System.Drawing.Point(416, 72);
            this.TxtProvincia.Name = "TxtProvincia";
            this.TxtProvincia.Size = new System.Drawing.Size(228, 22);
            this.TxtProvincia.TabIndex = 11;
            // 
            // CboxUsuario
            // 
            this.CboxUsuario.FormattingEnabled = true;
            this.CboxUsuario.Location = new System.Drawing.Point(18, 231);
            this.CboxUsuario.Name = "CboxUsuario";
            this.CboxUsuario.Size = new System.Drawing.Size(228, 24);
            this.CboxUsuario.TabIndex = 10;
            // 
            // TxtTransporte
            // 
            this.TxtTransporte.Location = new System.Drawing.Point(18, 149);
            this.TxtTransporte.Name = "TxtTransporte";
            this.TxtTransporte.Size = new System.Drawing.Size(228, 22);
            this.TxtTransporte.TabIndex = 9;
            // 
            // TxtCod
            // 
            this.TxtCod.Location = new System.Drawing.Point(18, 72);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.ReadOnly = true;
            this.TxtCod.Size = new System.Drawing.Size(228, 22);
            this.TxtCod.TabIndex = 8;
            // 
            // CbActivo
            // 
            this.CbActivo.AutoSize = true;
            this.CbActivo.Location = new System.Drawing.Point(933, 268);
            this.CbActivo.Name = "CbActivo";
            this.CbActivo.Size = new System.Drawing.Size(68, 21);
            this.CbActivo.TabIndex = 7;
            this.CbActivo.Text = "Activo";
            this.CbActivo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nombre de Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(751, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cantidad de Paradas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Distrito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantón";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Provincia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo de Transporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
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
            this.BtnAgregar.Location = new System.Drawing.Point(30, 555);
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
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(172, 555);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(116, 42);
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
            this.BtnEliminar.Location = new System.Drawing.Point(311, 555);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(116, 42);
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
            this.BtnLimpiar.Location = new System.Drawing.Point(671, 556);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(209, 41);
            this.BtnLimpiar.TabIndex = 0;
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
            this.BtnCancelar.Location = new System.Drawing.Point(900, 556);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 41);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmRutasGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 609);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.CbVerRutasActivas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRutasGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Rutas";
            this.Load += new System.EventHandler(this.FrmRutasGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CbVerRutasActivas;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CbActivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboxUsuario;
        private System.Windows.Forms.TextBox TxtTransporte;
        private System.Windows.Forms.TextBox TxtCod;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtDistrito;
        private System.Windows.Forms.TextBox TxtCanton;
        private System.Windows.Forms.TextBox TxtProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CParadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadParadas;
        private System.Windows.Forms.TextBox TxtParadas;
        private System.Windows.Forms.Label label9;
    }
}