
namespace Marovi.Formularios
{
    partial class FrmListaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaProductos));
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbVerProductosActivos = new System.Windows.Forms.CheckBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.ColIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioPorMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(473, 41);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(312, 22);
            this.TxtBuscar.TabIndex = 5;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar:";
            // 
            // CbVerProductosActivos
            // 
            this.CbVerProductosActivos.AutoSize = true;
            this.CbVerProductosActivos.Checked = true;
            this.CbVerProductosActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerProductosActivos.Location = new System.Drawing.Point(1153, 43);
            this.CbVerProductosActivos.Name = "CbVerProductosActivos";
            this.CbVerProductosActivos.Size = new System.Drawing.Size(169, 21);
            this.CbVerProductosActivos.TabIndex = 7;
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
            this.DgvLista.Location = new System.Drawing.Point(12, 90);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 51;
            this.DgvLista.RowTemplate.Height = 24;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(1415, 296);
            this.DgvLista.TabIndex = 8;
            this.DgvLista.VirtualMode = true;
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
            // FrmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 509);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.CbVerProductosActivos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Productos";
            this.Load += new System.EventHandler(this.FrmListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CbVerProductosActivos;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioPorMayor;
    }
}