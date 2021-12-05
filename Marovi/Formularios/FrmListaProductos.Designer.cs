
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
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbVerProductosActivos = new System.Windows.Forms.CheckBox();
            this.CIDFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNumFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDFactura,
            this.CNumFact,
            this.CFecha,
            this.CIDCliente});
            this.DgvLista.Location = new System.Drawing.Point(12, 84);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 51;
            this.DgvLista.RowTemplate.Height = 24;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(1310, 298);
            this.DgvLista.TabIndex = 4;
            this.DgvLista.VirtualMode = true;
            this.DgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLista_CellClick);
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
            // CIDFactura
            // 
            this.CIDFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIDFactura.DataPropertyName = "IDFactura";
            this.CIDFactura.HeaderText = "Código";
            this.CIDFactura.MinimumWidth = 6;
            this.CIDFactura.Name = "CIDFactura";
            this.CIDFactura.ReadOnly = true;
            this.CIDFactura.Width = 125;
            // 
            // CNumFact
            // 
            this.CNumFact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNumFact.DataPropertyName = "NumeroFactura";
            this.CNumFact.HeaderText = "Número Factura";
            this.CNumFact.MinimumWidth = 6;
            this.CNumFact.Name = "CNumFact";
            this.CNumFact.ReadOnly = true;
            // 
            // CFecha
            // 
            this.CFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CFecha.DataPropertyName = "Fecha";
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.MinimumWidth = 6;
            this.CFecha.Name = "CFecha";
            this.CFecha.ReadOnly = true;
            this.CFecha.Width = 125;
            // 
            // CIDCliente
            // 
            this.CIDCliente.DataPropertyName = "IDCliente";
            this.CIDCliente.HeaderText = "Cliente";
            this.CIDCliente.MinimumWidth = 6;
            this.CIDCliente.Name = "CIDCliente";
            this.CIDCliente.ReadOnly = true;
            this.CIDCliente.Width = 200;
            // 
            // FrmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 509);
            this.Controls.Add(this.CbVerProductosActivos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.DgvLista);
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

        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CbVerProductosActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNumFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDCliente;
    }
}