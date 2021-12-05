
namespace Marovi.Formularios
{
    partial class FrmFacturaDetalleGestion
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
            this.DgvListaProductos = new System.Windows.Forms.DataGridView();
            this.CIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.NudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListaProductos
            // 
            this.DgvListaProductos.AllowUserToAddRows = false;
            this.DgvListaProductos.AllowUserToDeleteRows = false;
            this.DgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDProducto,
            this.CNombre,
            this.CStock,
            this.CPrecioUnitario,
            this.CPrecioMayor});
            this.DgvListaProductos.Location = new System.Drawing.Point(22, 74);
            this.DgvListaProductos.Name = "DgvListaProductos";
            this.DgvListaProductos.RowHeadersVisible = false;
            this.DgvListaProductos.RowHeadersWidth = 51;
            this.DgvListaProductos.RowTemplate.Height = 24;
            this.DgvListaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaProductos.Size = new System.Drawing.Size(881, 282);
            this.DgvListaProductos.TabIndex = 0;
            this.DgvListaProductos.VirtualMode = true;
            // 
            // CIDProducto
            // 
            this.CIDProducto.DataPropertyName = "IDProducto";
            this.CIDProducto.HeaderText = "Código";
            this.CIDProducto.MinimumWidth = 6;
            this.CIDProducto.Name = "CIDProducto";
            this.CIDProducto.Width = 125;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Descripción";
            this.CNombre.MinimumWidth = 6;
            this.CNombre.Name = "CNombre";
            // 
            // CStock
            // 
            this.CStock.DataPropertyName = "StockFinal";
            this.CStock.HeaderText = "Stock";
            this.CStock.MinimumWidth = 6;
            this.CStock.Name = "CStock";
            this.CStock.Width = 125;
            // 
            // CPrecioUnitario
            // 
            this.CPrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.CPrecioUnitario.HeaderText = "Precio Unitario";
            this.CPrecioUnitario.MinimumWidth = 6;
            this.CPrecioUnitario.Name = "CPrecioUnitario";
            this.CPrecioUnitario.Width = 125;
            // 
            // CPrecioMayor
            // 
            this.CPrecioMayor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPrecioMayor.DataPropertyName = "PrecioPorMayor";
            this.CPrecioMayor.HeaderText = "Precio x Mayor";
            this.CPrecioMayor.MinimumWidth = 6;
            this.CPrecioMayor.Name = "CPrecioMayor";
            this.CPrecioMayor.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(310, 26);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(317, 22);
            this.TxtBuscar.TabIndex = 2;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // NudCantidad
            // 
            this.NudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudCantidad.Location = new System.Drawing.Point(383, 451);
            this.NudCantidad.Name = "NudCantidad";
            this.NudCantidad.Size = new System.Drawing.Size(120, 30);
            this.NudCantidad.TabIndex = 3;
            this.NudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad a Comprar";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(170)))), ((int)(((byte)(138)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(342, 534);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(118, 45);
            this.BtnAceptar.TabIndex = 5;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(466, 534);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(118, 45);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmFacturaDetalleGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 603);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NudCantidad);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvListaProductos);
            this.Name = "FrmFacturaDetalleGestion";
            this.Text = "FrmFacturaDetalleGestion";
            this.Load += new System.EventHandler(this.FrmFacturaDetalleGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.NumericUpDown NudCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioMayor;
        private System.Windows.Forms.DataGridView DgvListaProductos;
    }
}