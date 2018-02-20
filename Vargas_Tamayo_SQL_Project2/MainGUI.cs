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
         /// <summary>
         /// Class name: MainGUI()
         /// Class Author: Luis E. Vargas Tamayo
         /// Purpose of the class: Intermediate form from Login Form and Database form
         /// Date: 2/19/2018
         /// List of changes with dates: N/A
         /// Special Notes: N/A
         /// </summary>
        public MainGUI()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Method Name: mnuDatabaseView()
        /// Purpose: Opens the form to view the Database
        /// Parameter: String Username,Password
        /// Method Input: none
        /// Return Value:none
        /// Date: 2/19/2018
        /// </summary>
        private void mnuDatabaseView_Click(object sender, EventArgs e)
        {
            //INSTANTIATES FRAME
            Database frmDatabase = new Database("Luis2","Vargas005");

            //MAKES THIS FORM INVISIBLE
            this.Visible = false;

            //OPEN DIALOG
            frmDatabase.ShowDialog();

            //MAKES THIS FORM VISIBLE
            this.Visible = true;
        }
       
        /// <summary>
        /// Method Name: mnuFileExit()
        /// Purpose: Closes the form; terminates the program
        /// Parameter: none
        /// Method Input: none
        /// Return Value:none
        /// Date: 2/19/2018
        /// </summary>
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            //CLOSE THIS FORM
            Close(); 
        }

  
    }
}
