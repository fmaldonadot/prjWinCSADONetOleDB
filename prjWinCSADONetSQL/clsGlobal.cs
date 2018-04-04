using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace prjWinCSADONetSQL
{
    static class clsGlobal //cambiar todo a SQL client
    {
        public static OleDbConnection mycon;
        public static DataSet myset;
        public static OleDbDataAdapter adpFournisseur;
        public static OleDbDataAdapter adpApplication;
    }
}
