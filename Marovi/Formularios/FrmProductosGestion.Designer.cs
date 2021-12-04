
namespace Marovi.Formularios
{
    partial class FrmProductosGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductosGestion));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbVerProductosActivos = new System.Windows.Forms.CheckBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.ColIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioPorMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpCaducidad = new System.Windows.Forms.DateTimePicker();
            this.DtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.CboxCategoria = new System.Windows.Forms.ComboBox();
            this.TxtXMayor = new System.Windows.Forms.TextBox();
            this.TxtUnitario = new System.Windows.Forms.TextBox();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.TxtStockFinal = new System.Windows.Forms.TextBox();
            this.TxtSalidas = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtEntradas = new System.Windows.Forms.TextBox();
            this.TxtStockInicial = new System.Windows.Forms.TextBox();
            this.TxtCodigoBarras = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.CbActivo = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(587, 29);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(300, 22);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // CbVerProductosActivos
            // 
            this.CbVerProductosActivos.AutoSize = true;
            this.CbVerProductosActivos.Checked = true;
            this.CbVerProductosActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerProductosActivos.Location = new System.Drawing.Point(1258, 28);
            this.CbVerProductosActivos.Name = "CbVerProductosActivos";
            this.CbVerProductosActivos.Size = new System.Drawing.Size(169, 21);
            this.CbVerProductosActivos.TabIndex = 2;
            this.CbVerProductosActivos.Text = "Ver Productos Activos";
            this.CbVerProductosActivos.UseVisualStyleBackColor = true;
            this.CbVerProductosActivos.CheckedChanged += new System.EventHandler(this.CbVerProductosActivos_CheckedChanged);
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIDProducto,
            this.ColDescripcion,
            this.ColStock,
            this.ColPrecioUnitario,
            this.ColPrecioPorMayor});
            this.DgvLista.Location = new System.Drawing.Point(12, 81);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 51;
            this.DgvLista.RowTemplate.Height = 24;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(1415, 150);
            this.DgvLista.TabIndex = 3;
            this.DgvLista.VirtualMode = true;
            this.DgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLista_CellClick);
            // 
            // ColIDProducto
            // 
            this.ColIDProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColIDProducto.DataPropertyName = "IDProducto";
            this.ColIDProducto.HeaderText = "Código";
            this.ColIDProducto.MinimumWidth = 6;
            this.ColIDProducto.Name = "ColIDProducto";
            this.ColIDProducto.ReadOnly = true;
            this.ColIDProducto.Width = 125;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDescripcion.DataPropertyName = "Descripcion";
            this.ColDescripcion.HeaderText = "Descripción";
            this.ColDescripcion.MinimumWidth = 6;
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            // 
            // ColStock
            // 
            this.ColStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColStock.DataPropertyName = "StockFinal";
            this.ColStock.HeaderText = "Stock";
            this.ColStock.MinimumWidth = 6;
            this.ColStock.Name = "ColStock";
            this.ColStock.ReadOnly = true;
            this.ColStock.Width = 125;
            // 
            // ColPrecioUnitario
            // 
            this.ColPrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.ColPrecioUnitario.HeaderText = "Precio Unitario";
            this.ColPrecioUnitario.MinimumWidth = 6;
            this.ColPrecioUnitario.Name = "ColPrecioUnitario";
            this.ColPrecioUnitario.ReadOnly = true;
            this.ColPrecioUnitario.Width = 200;
            // 
            // ColPrecioPorMayor
            // 
            this.ColPrecioPorMayor.DataPropertyName = "PrecioPorMayor";
            this.ColPrecioPorMayor.HeaderText = "Precio x Mayor";
            this.ColPrecioPorMayor.MinimumWidth = 6;
            this.ColPrecioPorMayor.Name = "ColPrecioPorMayor";
            this.ColPrecioPorMayor.ReadOnly = true;
            this.ColPrecioPorMayor.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtpCaducidad);
            this.groupBox1.Controls.Add(this.DtpIngreso);
            this.groupBox1.Controls.Add(this.CboxCategoria);
            this.groupBox1.Controls.Add(this.TxtXMayor);
            this.groupBox1.Controls.Add(this.TxtUnitario);
            this.groupBox1.Controls.Add(this.TxtPeso);
            this.groupBox1.Controls.Add(this.TxtStockFinal);
            this.groupBox1.Controls.Add(this.TxtSalidas);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TxtEntradas);
            this.groupBox1.Controls.Add(this.TxtStockInicial);
            this.groupBox1.Controls.Add(this.TxtCodigoBarras);
            this.groupBox1.Controls.Add(this.TxtDescripcion);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.TxtCod);
            this.groupBox1.Controls.Add(this.CbActivo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1415, 361);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // DtpCaducidad
            // 
            this.DtpCaducidad.Location = new System.Drawing.Point(1111, 132);
            this.DtpCaducidad.Name = "DtpCaducidad";
            this.DtpCaducidad.Size = new System.Drawing.Size(271, 22);
            this.DtpCaducidad.TabIndex = 30;
            // 
            // DtpIngreso
            // 
            this.DtpIngreso.Location = new System.Drawing.Point(1111, 61);
            this.DtpIngreso.Name = "DtpIngreso";
            this.DtpIngreso.Size = new System.Drawing.Size(271, 22);
            this.DtpIngreso.TabIndex = 29;
            // 
            // CboxCategoria
            // 
            this.CboxCategoria.FormattingEnabled = true;
            this.CboxCategoria.Location = new System.Drawing.Point(1111, 215);
            this.CboxCategoria.Name = "CboxCategoria";
            this.CboxCategoria.Size = new System.Drawing.Size(271, 24);
            this.CboxCategoria.TabIndex = 28;
            // 
            // TxtXMayor
            // 
            this.TxtXMayor.Location = new System.Drawing.Point(745, 297);
            this.TxtXMayor.Name = "TxtXMayor";
            this.TxtXMayor.Size = new System.Drawing.Size(254, 22);
            this.TxtXMayor.TabIndex = 25;
            // 
            // TxtUnitario
            // 
            this.TxtUnitario.Location = new System.Drawing.Point(745, 217);
            this.TxtUnitario.Name = "TxtUnitario";
            this.TxtUnitario.Size = new System.Drawing.Size(254, 22);
            this.TxtUnitario.TabIndex = 24;
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(745, 134);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(254, 22);
            this.TxtPeso.TabIndex = 23;
            // 
            // TxtStockFinal
            // 
            this.TxtStockFinal.Location = new System.Drawing.Point(745, 63);
            this.TxtStockFinal.Name = "TxtStockFinal";
            this.TxtStockFinal.Size = new System.Drawing.Size(254, 22);
            this.TxtStockFinal.TabIndex = 22;
            // 
            // TxtSalidas
            // 
            this.TxtSalidas.Location = new System.Drawing.Point(396, 297);
            this.TxtSalidas.Name = "TxtSalidas";
            this.TxtSalidas.Size = new System.Drawing.Size(254, 22);
            this.TxtSalidas.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1108, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 17);
            this.label15.TabIndex = 13;
            this.label15.Text = "Categoria";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1108, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "Fecha de Caducidad";
            // 
            // TxtEntradas
            // 
            this.TxtEntradas.Location = new System.Drawing.Point(396, 217);
            this.TxtEntradas.Name = "TxtEntradas";
            this.TxtEntradas.Size = new System.Drawing.Size(254, 22);
            this.TxtEntradas.TabIndex = 20;
            // 
            // TxtStockInicial
            // 
            this.TxtStockInicial.Location = new System.Drawing.Point(396, 134);
            this.TxtStockInicial.Name = "TxtStockInicial";
            this.TxtStockInicial.Size = new System.Drawing.Size(254, 22);
            this.TxtStockInicial.TabIndex = 19;
            // 
            // TxtCodigoBarras
            // 
            this.TxtCodigoBarras.Location = new System.Drawing.Point(396, 63);
            this.TxtCodigoBarras.Name = "TxtCodigoBarras";
            this.TxtCodigoBarras.Size = new System.Drawing.Size(254, 22);
            this.TxtCodigoBarras.TabIndex = 18;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(19, 217);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDescripcion.Size = new System.Drawing.Size(254, 102);
            this.TxtDescripcion.TabIndex = 17;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(19, 134);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(254, 22);
            this.TxtNombre.TabIndex = 16;
            // 
            // TxtCod
            // 
            this.TxtCod.Location = new System.Drawing.Point(19, 63);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.ReadOnly = true;
            this.TxtCod.Size = new System.Drawing.Size(254, 22);
            this.TxtCod.TabIndex = 15;
            // 
            // CbActivo
            // 
            this.CbActivo.AutoSize = true;
            this.CbActivo.Location = new System.Drawing.Point(1111, 281);
            this.CbActivo.Name = "CbActivo";
            this.CbActivo.Size = new System.Drawing.Size(68, 21);
            this.CbActivo.TabIndex = 14;
            this.CbActivo.Text = "Activo";
            this.CbActivo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1108, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Fecha Ingreso";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(742, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Precio Al Por Mayor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(742, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Precio Unitario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(742, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Peso";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(742, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Stock Final";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Salidas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Entradas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Stock Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Código de Barras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 33);
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
            this.BtnAgregar.Location = new System.Drawing.Point(64, 639);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(118, 45);
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
            this.BtnEditar.Location = new System.Drawing.Point(208, 639);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(105, 45);
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
            this.BtnEliminar.Location = new System.Drawing.Point(338, 639);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(111, 45);
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
            this.BtnLimpiar.Location = new System.Drawing.Point(1090, 639);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(219, 45);
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
            this.BtnCancelar.Location = new System.Drawing.Point(1329, 639);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(98, 45);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmProductosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 706);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.CbVerProductosActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmProductosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Productos";
            this.Load += new System.EventHandler(this.FrmProductosGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CbVerProductosActivos;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CbActivo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCodigoBarras;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioPorMayor;
        private System.Windows.Forms.ComboBox CboxCategoria;
        private System.Windows.Forms.TextBox TxtXMayor;
        private System.Windows.Forms.TextBox TxtUnitario;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.TextBox TxtStockFinal;
        private System.Windows.Forms.TextBox TxtSalidas;
        private System.Windows.Forms.TextBox TxtEntradas;
        private System.Windows.Forms.TextBox TxtStockInicial;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DateTimePicker DtpCaducidad;
        private System.Windows.Forms.DateTimePicker DtpIngreso;
    }
}