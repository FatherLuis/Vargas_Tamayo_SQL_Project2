using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vargas_Tamayo_SQL_Project2
{
    public partial class Database : Form
    {
        private mySQL myDatabase;

        public Database(String username, String Password)
        {
            InitializeComponent();
            myDatabase = new mySQL("LUIS", "Vargas");
        }

        

        public void READ_TABLE()
        {

            dgvViewData.DataSource = myDatabase.ImportData("TABLE NAME");



        }
        













    }
}
