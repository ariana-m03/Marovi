
namespace Marovi.Formularios
{
    partial class FrmListaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaUsuarios));
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbVerUsuariosActivos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CCedula,
            this.CNombre,
            this.CEmail});
            this.DgvLista.Location = new System.Drawing.Point(12, 86);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 51;
            this.DgvLista.RowTemplate.Height = 24;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(964, 299);
            this.DgvLista.TabIndex = 0;
            this.DgvLista.VirtualMode = true;
            // 
            // CID
            // 
            this.CID.DataPropertyName = "IDUsuario";
            this.CID.HeaderText = "Código";
            this.CID.MinimumWidth = 6;
            this.CID.Name = "CID";
            this.CID.Width = 80;
            // 
            // CCedula
            // 
            this.CCedula.DataPropertyName = "Cedula";
            this.CCedula.HeaderText = "Cédula";
            this.CCedula.MinimumWidth = 6;
            this.CCedula.Name = "CCedula";
            this.CCedula.Width = 125;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.MinimumWidth = 6;
            this.CNombre.Name = "CNombre";
            // 
            // CEmail
            // 
            this.CEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CEmail.DataPropertyName = "Username";
            this.CEmail.HeaderText = "Email";
            this.CEmail.MinimumWidth = 6;
            this.CEmail.Name = "CEmail";
            this.CEmail.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(360, 30);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(312, 22);
            this.TxtBuscar.TabIndex = 2;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // CbVerUsuariosActivos
            // 
            this.CbVerUsuariosActivos.AutoSize = true;
            this.CbVerUsuariosActivos.Checked = true;
            this.CbVerUsuariosActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerUsuariosActivos.Location = new System.Drawing.Point(815, 32);
            this.CbVerUsuariosActivos.Name = "CbVerUsuariosActivos";
            this.CbVerUsuariosActivos.Size = new System.Drawing.Size(161, 21);
            this.CbVerUsuariosActivos.TabIndex = 3;
            this.CbVerUsuariosActivos.Text = "Ver Usuarios Activos";
            this.CbVerUsuariosActivos.UseVisualStyleBackColor = true;
            this.CbVerUsuariosActivos.CheckedChanged += new System.EventHandler(this.CbVerUsuariosActivos_CheckedChanged);
            // 
            // FrmListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 510);
            this.Controls.Add(this.CbVerUsuariosActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmListaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Usuarios";
            this.Load += new System.EventHandler(this.FrmListaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CbVerUsuariosActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEmail;
    }
}