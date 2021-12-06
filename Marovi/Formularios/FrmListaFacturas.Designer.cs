
namespace Marovi.Formularios
{
    partial class FrmListaFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaFacturas));
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.CIDFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnAnular = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.CbVerFacturasActivas = new System.Windows.Forms.CheckBox();
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
            this.CNumeroFactura,
            this.CFecha,
            this.CNombre});
            this.DgvLista.Location = new System.Drawing.Point(12, 88);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 51;
            this.DgvLista.RowTemplate.Height = 24;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(1310, 298);
            this.DgvLista.TabIndex = 5;
            this.DgvLista.VirtualMode = true;
            
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
            // CNumeroFactura
            // 
            this.CNumeroFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNumeroFactura.DataPropertyName = "NumeroFactura";
            this.CNumeroFactura.HeaderText = "Número Factura";
            this.CNumeroFactura.MinimumWidth = 6;
            this.CNumeroFactura.Name = "CNumeroFactura";
            this.CNumeroFactura.ReadOnly = true;
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
            // CNombre
            // 
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.MinimumWidth = 6;
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            this.CNombre.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(537, 41);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(312, 22);
            this.TxtBuscar.TabIndex = 8;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // BtnAnular
            // 
            this.BtnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(126)))), ((int)(((byte)(125)))));
            this.BtnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnular.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnular.ForeColor = System.Drawing.Color.White;
            this.BtnAnular.Location = new System.Drawing.Point(1153, 423);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(169, 53);
            this.BtnAnular.TabIndex = 9;
            this.BtnAnular.Text = "Anular Factura";
            this.BtnAnular.UseVisualStyleBackColor = false;
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.ForeColor = System.Drawing.Color.White;
            this.BtnMostrar.Location = new System.Drawing.Point(978, 423);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(169, 53);
            this.BtnMostrar.TabIndex = 10;
            this.BtnMostrar.Text = "Mostrar Reporte";
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // CbVerFacturasActivas
            // 
            this.CbVerFacturasActivas.AutoSize = true;
            this.CbVerFacturasActivas.Checked = true;
            this.CbVerFacturasActivas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerFacturasActivas.Location = new System.Drawing.Point(1163, 45);
            this.CbVerFacturasActivas.Name = "CbVerFacturasActivas";
            this.CbVerFacturasActivas.Size = new System.Drawing.Size(160, 21);
            this.CbVerFacturasActivas.TabIndex = 11;
            this.CbVerFacturasActivas.Text = "Ver Facturas Activas";
            this.CbVerFacturasActivas.UseVisualStyleBackColor = true;
            this.CbVerFacturasActivas.CheckedChanged += new System.EventHandler(this.CbVerFacturasActivas_CheckedChanged);
            // 
            // FrmListaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 517);
            this.Controls.Add(this.CbVerFacturasActivas);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnAnular);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListaFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Facturas";
            this.Load += new System.EventHandler(this.FrmListaFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnAnular;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.CheckBox CbVerFacturasActivas;
    }
}