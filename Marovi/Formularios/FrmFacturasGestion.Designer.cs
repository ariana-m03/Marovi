
namespace Marovi.Formularios
{
    partial class FrmFacturasGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturasGestion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboxCliente = new System.Windows.Forms.ComboBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtNumFact = new System.Windows.Forms.TextBox();
            this.LblUsuarioRegistra = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnAgregarProducto = new System.Windows.Forms.ToolStripButton();
            this.BtnEliminarProducto = new System.Windows.Forms.ToolStripButton();
            this.DgvListaF = new System.Windows.Forms.DataGridView();
            this.ColCodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUnitario = new System.Windows.Forms.TextBox();
            this.BtnCrearFactura = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMayor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaF)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboxCliente);
            this.groupBox1.Controls.Add(this.DtpFecha);
            this.groupBox1.Controls.Add(this.TxtNumFact);
            this.groupBox1.Controls.Add(this.LblUsuarioRegistra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CboxCliente
            // 
            this.CboxCliente.FormattingEnabled = true;
            this.CboxCliente.Location = new System.Drawing.Point(467, 46);
            this.CboxCliente.Name = "CboxCliente";
            this.CboxCliente.Size = new System.Drawing.Size(268, 24);
            this.CboxCliente.TabIndex = 6;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(30, 136);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(273, 22);
            this.DtpFecha.TabIndex = 5;
            // 
            // TxtNumFact
            // 
            this.TxtNumFact.Location = new System.Drawing.Point(30, 48);
            this.TxtNumFact.Name = "TxtNumFact";
            this.TxtNumFact.Size = new System.Drawing.Size(273, 22);
            this.TxtNumFact.TabIndex = 4;
            // 
            // LblUsuarioRegistra
            // 
            this.LblUsuarioRegistra.AutoSize = true;
            this.LblUsuarioRegistra.Location = new System.Drawing.Point(464, 101);
            this.LblUsuarioRegistra.Name = "LblUsuarioRegistra";
            this.LblUsuarioRegistra.Size = new System.Drawing.Size(46, 17);
            this.LblUsuarioRegistra.TabIndex = 3;
            this.LblUsuarioRegistra.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha de Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número de Factura";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.DgvListaF);
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(815, 478);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAgregarProducto,
            this.BtnEliminarProducto});
            this.toolStrip1.Location = new System.Drawing.Point(3, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(809, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.BtnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarProducto.Image")));
            this.BtnAgregarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(151, 24);
            this.BtnAgregarProducto.Text = "Agregar Producto";
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(158)))));
            this.BtnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarProducto.Image")));
            this.BtnEliminarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Size = new System.Drawing.Size(151, 24);
            this.BtnEliminarProducto.Text = "Eliminar Producto";
            this.BtnEliminarProducto.Click += new System.EventHandler(this.BtnEliminarProducto_Click);
            // 
            // DgvListaF
            // 
            this.DgvListaF.AllowUserToAddRows = false;
            this.DgvListaF.AllowUserToDeleteRows = false;
            this.DgvListaF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodProd,
            this.CNombre,
            this.CCantidad,
            this.CPrecioUnitario,
            this.CPrecioMayor});
            this.DgvListaF.Location = new System.Drawing.Point(18, 51);
            this.DgvListaF.Name = "DgvListaF";
            this.DgvListaF.RowHeadersVisible = false;
            this.DgvListaF.RowHeadersWidth = 51;
            this.DgvListaF.RowTemplate.Height = 24;
            this.DgvListaF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaF.Size = new System.Drawing.Size(776, 384);
            this.DgvListaF.TabIndex = 0;
            this.DgvListaF.VirtualMode = true;
            // 
            // ColCodProd
            // 
            this.ColCodProd.DataPropertyName = "IDProducto";
            this.ColCodProd.HeaderText = "Cód. Producto";
            this.ColCodProd.MinimumWidth = 6;
            this.ColCodProd.Name = "ColCodProd";
            this.ColCodProd.Width = 125;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Producto";
            this.CNombre.MinimumWidth = 6;
            this.CNombre.Name = "CNombre";
            // 
            // CCantidad
            // 
            this.CCantidad.DataPropertyName = "Cantidad";
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.MinimumWidth = 6;
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.Width = 125;
            // 
            // CPrecioUnitario
            // 
            this.CPrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.CPrecioUnitario.HeaderText = "Precio Unitario";
            this.CPrecioUnitario.MinimumWidth = 6;
            this.CPrecioUnitario.Name = "CPrecioUnitario";
            this.CPrecioUnitario.Width = 125;
            // 
            // CPrecioMayor
            // 
            this.CPrecioMayor.DataPropertyName = "PrecioPorMayor";
            this.CPrecioMayor.HeaderText = "Precio Por Mayor";
            this.CPrecioMayor.MinimumWidth = 6;
            this.CPrecioMayor.Name = "CPrecioMayor";
            this.CPrecioMayor.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 699);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Unitario";
            // 
            // TxtUnitario
            // 
            this.TxtUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnitario.Location = new System.Drawing.Point(164, 699);
            this.TxtUnitario.Name = "TxtUnitario";
            this.TxtUnitario.ReadOnly = true;
            this.TxtUnitario.Size = new System.Drawing.Size(205, 30);
            this.TxtUnitario.TabIndex = 3;
            this.TxtUnitario.Text = "0";
            this.TxtUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCrearFactura
            // 
            this.BtnCrearFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(170)))), ((int)(((byte)(138)))));
            this.BtnCrearFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearFactura.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearFactura.ForeColor = System.Drawing.Color.White;
            this.BtnCrearFactura.Location = new System.Drawing.Point(509, 709);
            this.BtnCrearFactura.Name = "BtnCrearFactura";
            this.BtnCrearFactura.Size = new System.Drawing.Size(156, 49);
            this.BtnCrearFactura.TabIndex = 4;
            this.BtnCrearFactura.Text = "Crear Factura";
            this.BtnCrearFactura.UseVisualStyleBackColor = false;
            this.BtnCrearFactura.Click += new System.EventHandler(this.BtnCrearFactura_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(177)))));
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(671, 709);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(156, 49);
            this.BtnLimpiar.TabIndex = 5;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 744);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Mayorista";
            // 
            // TxtMayor
            // 
            this.TxtMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMayor.Location = new System.Drawing.Point(164, 741);
            this.TxtMayor.Name = "TxtMayor";
            this.TxtMayor.ReadOnly = true;
            this.TxtMayor.Size = new System.Drawing.Size(205, 30);
            this.TxtMayor.TabIndex = 7;
            this.TxtMayor.Text = "0";
            this.TxtMayor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmFacturasGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 792);
            this.Controls.Add(this.TxtMayor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCrearFactura);
            this.Controls.Add(this.TxtUnitario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFacturasGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Facturación";
            this.Load += new System.EventHandler(this.FrmFacturasGestion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUnitario;
        private System.Windows.Forms.Button BtnCrearFactura;
        private System.Windows.Forms.ComboBox CboxCliente;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.TextBox TxtNumFact;
        private System.Windows.Forms.Label LblUsuarioRegistra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnAgregarProducto;
        private System.Windows.Forms.ToolStripButton BtnEliminarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioMayor;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMayor;
        private System.Windows.Forms.DataGridView DgvListaF;
    }
}