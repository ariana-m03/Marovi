
namespace Marovi.Formularios
{
    partial class FrmListaRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaRutas));
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.CIDRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CParadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadParadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbVerRutasActivas = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.SuspendLayout();
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
            this.DgvLista.Location = new System.Drawing.Point(12, 89);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 51;
            this.DgvLista.RowTemplate.Height = 24;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(1007, 342);
            this.DgvLista.TabIndex = 4;
            this.DgvLista.VirtualMode = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(344, 24);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(300, 22);
            this.TxtBuscar.TabIndex = 6;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // CbVerRutasActivas
            // 
            this.CbVerRutasActivas.AutoSize = true;
            this.CbVerRutasActivas.Checked = true;
            this.CbVerRutasActivas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerRutasActivas.Location = new System.Drawing.Point(876, 27);
            this.CbVerRutasActivas.Name = "CbVerRutasActivas";
            this.CbVerRutasActivas.Size = new System.Drawing.Size(142, 21);
            this.CbVerRutasActivas.TabIndex = 7;
            this.CbVerRutasActivas.Text = "Ver Rutas Activas";
            this.CbVerRutasActivas.UseVisualStyleBackColor = true;
            this.CbVerRutasActivas.CheckedChanged += new System.EventHandler(this.CbVerRutasActivas_CheckedChanged);
            // 
            // FrmListaRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 516);
            this.Controls.Add(this.CbVerRutasActivas);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListaRutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Rutas";
            this.Load += new System.EventHandler(this.FrmListaRutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CParadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadParadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CbVerRutasActivas;
    }
}