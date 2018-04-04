using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace prjWinCSADONetSQL
{
    public partial class frmFournisseur : Form
    {
        public frmFournisseur()
        {
            InitializeComponent();
        }

        DataTable tbFournisseur;
        int courant;
        string mode;

        private void frmFournisseur_Load(object sender, EventArgs e)
        {
            courant = 0;
            tbFournisseur = clsGlobal.myset.Tables["Fournisseurs"];

            Tab2Txt();
        }

        private void Tab2Txt()
        {
            txtNom.Text = tbFournisseur.Rows[courant]["Nom"].ToString();
            txtSiege.Text = tbFournisseur.Rows[courant]["Siege"].ToString();
            txtAnneCreation.Text = tbFournisseur.Rows[courant]["AnneCreation"].ToString();
            txtDescription.Text = tbFournisseur.Rows[courant]["Description"].ToString();

            lblInfo.Text = "Fournisseur " + (courant + 1) + " sur un total de " + tbFournisseur.Rows.Count;
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            courant = 0;

            Tab2Txt();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (courant > 0)
                courant--;

            Tab2Txt();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (courant < tbFournisseur.Rows.Count - 1)
                courant++;

            Tab2Txt();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            courant = tbFournisseur.Rows.Count - 1;

            Tab2Txt();
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtNom.Focus();
            txtSiege.Clear();
            txtAnneCreation.Clear();
            txtDescription.Clear();

            lblInfo.Text = "En mode Ajout d'un nouveau Fournisseur";

            mode = "ajout";
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            txtNom.Focus();
            lblInfo.Text = "En mode Modifier Fournisseur";

            mode = "modif";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow myrow = null;

            if (mode == "ajout")
            {
                myrow = tbFournisseur.NewRow();
            }
            if (mode == "modif")
            {
                myrow = tbFournisseur.Rows[courant];
            }

            myrow["Nom"] = txtNom.Text;
            myrow["Siege"] = txtSiege.Text;
            myrow["AnneCreation"] = Convert.ToInt16(txtAnneCreation.Text);
            myrow["Description"] = txtDescription.Text;

            if (mode == "ajout")
            {
                tbFournisseur.Rows.Add(myrow);
                courant = tbFournisseur.Rows.Count - 1;
            }

            mode = "";

            // Sincronizer ou sauvegarder le contenu du DataSet ver la DB
            // Save into DB
            OleDbCommandBuilder mybuilder = new OleDbCommandBuilder(clsGlobal.adpFournisseur);
            clsGlobal.adpFournisseur.Update(tbFournisseur);

            Tab2Txt();            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Est-vous sur de vouloir supprimer cet fournniseur?", "Suppresion de Fournniseur", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                try
                {
                    tbFournisseur.Rows[courant].Delete();
                    //tbFournisseur.Rows.RemoveAt(courant);                

                    courant = 0;
                    // Sincronizer ou sauvegarder le contenu du DataSet ver la DB
                    // Save into DB
                    OleDbCommandBuilder mybuilder = new OleDbCommandBuilder(clsGlobal.adpFournisseur);
                    clsGlobal.adpFournisseur.Update(tbFournisseur);
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Tab2Txt();

        }
    }
}
