using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCSADONetSQL
{
    public partial class frmApplication : Form
    {
        public frmApplication()
        {
            InitializeComponent();
        }
        DataTable tbApplication;
        DataTable tbFournisseur;

        int courant = 0;

        private void frmApplication_Load(object sender, EventArgs e)
        {
            tbApplication = clsGlobal.myset.Tables["Applications"];
            tbFournisseur = clsGlobal.myset.Tables["Fournisseurs"];

            tab2Txt();

            remplirLaListe();

        }

        private void remplirLaListe()
        {
            // Version Loop
            //foreach (DataRow myrow in tbFournisseur.Rows)
            //{
            //    cboFournisseur.Items.Add(myrow["Nom"].ToString());
            //}

            // Version DataBiding
            cboFournisseur.DisplayMember = "Nom";
            cboFournisseur.ValueMember = "RefFournisseur";
            cboFournisseur.DataSource = tbFournisseur;
        }

        public void tab2Txt()
        {
            txtNom.Text = tbApplication.Rows[courant]["Nom"].ToString();
            txtVersion.Text = tbApplication.Rows[courant]["Version"].ToString();
            txtPlateforme.Text = tbApplication.Rows[courant]["Plateforme"].ToString();
            dtimeApplication.Value = (DateTime)tbApplication.Rows[courant]["Date"];
            txtDescription.Text = tbApplication.Rows[courant]["Description"].ToString();

            cboFournisseur.Text = tbApplication.Rows[courant]["RefFournisseur"].ToString();

            lblInfo.Text = "Application " + (courant + 1) + " sur un total de " + tbFournisseur.Rows.Count;
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            courant = 0;
            tab2Txt();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (courant > 0)
                courant--;

            tab2Txt();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (courant < tbApplication.Rows.Count - 1)
                courant++;

            tab2Txt();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            courant = tbApplication.Rows.Count - 1;

            tab2Txt();
        }
    }
}
