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

        public Database(String username, String password)
        {
            InitializeComponent();
            myDatabase = new mySQL(username, password);
        }

        

        private void Database_Load(object sender, EventArgs e)
        {
            dgvViewData.DataSource = myDatabase.ImportData("Student_Table");
            dgvViewData.Visible = true;
        }
    }
}
