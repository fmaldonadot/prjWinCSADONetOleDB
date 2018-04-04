namespace prjWinCSADONetSQL
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.demarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFournisseurs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecherche = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demarrerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // demarrerToolStripMenuItem
            // 
            this.demarrerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGestion,
            this.mnuRecherche,
            this.mnuQuitter});
            this.demarrerToolStripMenuItem.Name = "demarrerToolStripMenuItem";
            this.demarrerToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.demarrerToolStripMenuItem.Text = "Demarrer";
            this.demarrerToolStripMenuItem.Click += new System.EventHandler(this.demarrerToolStripMenuItem_Click);
            // 
            // mnuGestion
            // 
            this.mnuGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFournisseurs,
            this.mnuApplications});
            this.mnuGestion.Name = "mnuGestion";
            this.mnuGestion.Size = new System.Drawing.Size(152, 22);
            this.mnuGestion.Text = "Gestion";
            // 
            // mnuFournisseurs
            // 
            this.mnuFournisseurs.Name = "mnuFournisseurs";
            this.mnuFournisseurs.Size = new System.Drawing.Size(152, 22);
            this.mnuFournisseurs.Text = "Fournisseurs";
            this.mnuFournisseurs.Click += new System.EventHandler(this.mnuFournisseurs_Click);
            // 
            // mnuApplications
            // 
            this.mnuApplications.Name = "mnuApplications";
            this.mnuApplications.Size = new System.Drawing.Size(152, 22);
            this.mnuApplications.Text = "Applications";
            this.mnuApplications.Click += new System.EventHandler(this.mnuApplications_Click);
            // 
            // mnuRecherche
            // 
            this.mnuRecherche.Name = "mnuRecherche";
            this.mnuRecherche.Size = new System.Drawing.Size(152, 22);
            this.mnuRecherche.Text = "Recherche";
            this.mnuRecherche.Click += new System.EventHandler(this.mnuRecherche_Click);
            // 
            // mnuQuitter
            // 
            this.mnuQuitter.Name = "mnuQuitter";
            this.mnuQuitter.Size = new System.Drawing.Size(152, 22);
            this.mnuQuitter.Text = "Quitter";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 321);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Système de Gestion des Logiciels";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem demarrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGestion;
        private System.Windows.Forms.ToolStripMenuItem mnuFournisseurs;
        private System.Windows.Forms.ToolStripMenuItem mnuApplications;
        private System.Windows.Forms.ToolStripMenuItem mnuRecherche;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitter;
    }
}