using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADODB;
using System.Data.OleDb;

namespace prjWinCSADONetSQL
{
    public partial class frmRecherche : Form
    {
        OleDbConnection mycon;
        DataSet mySet = new DataSet();
        public frmRecherche()
        {
            InitializeComponent();
        }

        private void frmRecherche_Load(object sender, EventArgs e)
        {
            mycon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\\Users\\fmtchicho\\Documents\\Visual Studio 2015\\Projects\\prjWinCSADONetSQL\\prjWinCSADONetSQL\\bin\\Debug\\data\\dbLogiciels.accdb'");
            mycon.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM Fournisseurs", mycon);

            OleDbDataAdapter adpFour = new OleDbDataAdapter(command);

            adpFour.Fill(mySet, "Fournisseurs");

            OleDbCommand command2 = new OleDbCommand("SELECT * FROM Applications", mycon);

            OleDbDataAdapter adpApp = new OleDbDataAdapter(command2);

            adpApp.Fill(mySet, "Applications");

            gridresultat.DataSource = mySet.Tables[0];

            string info = "";

            foreach (DataTable mytb in mySet.Tables)
            {
                info += "Table: " + mytb.TableName + "\n";
                
                foreach(DataColumn mycol in mytb.Columns)
                {
                    info += "\t Champ: " +mycol.ColumnName+ " " +mycol.DataType.ToString()+ "\n"; 
                }
                foreach(DataRow myrow in mytb.Rows)
                {
                    info += "\t\tEnrigestrement: " + myrow[1].ToString() + "\n";
                    info += "\t\tEnrigestrement: " + myrow[2].ToString() + "\n";
                    info += "\t\tEnrigestrement: " + myrow[3].ToString() + "\n";
                }
            }

            MessageBox.Show(info);
        }
    }
}
