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
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
        }

        private void mnuDatabaseView_Click(object sender, EventArgs e)
        {
            //INSTANTIATES FRAME
            Database frmDatabase = new Database("Luis2","Vargas005");

            //OPEN DIALOG
            frmDatabase.ShowDialog();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            //CLOSE THIS FORM
            Close(); 
        }

  
    }
}
