namespace prjWinCSADONetSQL
{
    partial class frmRecherche
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
            this.gridresultat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridresultat)).BeginInit();
            this.SuspendLayout();
            // 
            // gridresultat
            // 
            this.gridresultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridresultat.Location = new System.Drawing.Point(12, 167);
            this.gridresultat.Name = "gridresultat";
            this.gridresultat.Size = new System.Drawing.Size(432, 180);
            this.gridresultat.TabIndex = 0;
            // 
            // frmRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 359);
            this.Controls.Add(this.gridresultat);
            this.Name = "frmRecherche";
            this.Text = "frmRecherche";
            this.Load += new System.EventHandler(this.frmRecherche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridresultat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridresultat;
    }
}