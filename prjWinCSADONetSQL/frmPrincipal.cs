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
using System.Data;

namespace prjWinCSADONetSQL
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void demarrerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuRecherche_Click(object sender, EventArgs e)
        {
            frmRecherche frmrech = new frmRecherche();
            frmrech.MdiParent = this;
            frmrech.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsGlobal.mycon = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'C:\\Users\\fmtchicho\\Documents\\Visual Studio 2015\\Projects\\prjWinCSADONetSQL\\prjWinCSADONetSQL\\bin\\Debug\\data\\dbLogiciels.accdb'");
            clsGlobal.mycon.Open();

            OleDbCommand mycmd = new OleDbCommand("SELECT * FROM Fournisseurs", clsGlobal.mycon);
            clsGlobal.adpFournisseur = new OleDbDataAdapter(mycmd);
            clsGlobal.myset = new DataSet();
            clsGlobal.adpFournisseur.Fill(clsGlobal.myset, "Fournisseurs");

            OleDbCommand mycmd2 = new OleDbCommand("SELECT * FROM Applications", clsGlobal.mycon);
            clsGlobal.adpApplication = new OleDbDataAdapter(mycmd2);
            clsGlobal.adpApplication.Fill(clsGlobal.myset, "Applications");

            clsGlobal.myset.Relations.Add(new DataRelation("FA", clsGlobal.myset.Tables["Fournisseurs"].Columns["RefFournisseur"], clsGlobal.myset.Tables["Applications"].Columns["RefFournisseur"]));
        }

        private void mnuFournisseurs_Click(object sender, EventArgs e)
        {
            frmFournisseur fm = new frmFournisseur();
            fm.MdiParent = this;
            fm.Show();

        }

        private void mnuApplications_Click(object sender, EventArgs e)
        {
            frmApplication fa = new frmApplication();
            fa.MdiParent = this;
            fa.Show();
        }
    }
}
