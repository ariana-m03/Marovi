
namespace Marovi.Formularios
{
    partial class FrmVisualizadorReportes
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
            this.CrvVisualizadorReportes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrvVisualizadorReportes
            // 
            this.CrvVisualizadorReportes.ActiveViewIndex = -1;
            this.CrvVisualizadorReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvVisualizadorReportes.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrvVisualizadorReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrvVisualizadorReportes.Location = new System.Drawing.Point(0, 0);
            this.CrvVisualizadorReportes.Name = "CrvVisualizadorReportes";
            this.CrvVisualizadorReportes.ShowGroupTreeButton = false;
            this.CrvVisualizadorReportes.ShowLogo = false;
            this.CrvVisualizadorReportes.ShowParameterPanelButton = false;
            this.CrvVisualizadorReportes.Size = new System.Drawing.Size(800, 768);
            this.CrvVisualizadorReportes.TabIndex = 0;
            this.CrvVisualizadorReportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmVisualizadorReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.CrvVisualizadorReportes);
            this.Name = "FrmVisualizadorReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de Reportes";
            this.Load += new System.EventHandler(this.FrmVisualizadorReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CrvVisualizadorReportes;
    }
}