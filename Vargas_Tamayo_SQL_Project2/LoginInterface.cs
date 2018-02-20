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
     /// <summary>
     /// Class name: LoginInterface()
     /// Class Author: Luis E. Vargas Tamayo
     /// Purpose of the class: Login Form
     /// Date: 2/19/2018
     /// List of changes with dates: N/A
     /// Special Notes: N/A
     /// </summary>
    public partial class LoginInterface : Form
    {
        /// <summary>
        /// Method Name: LoginInterface
        /// Purpose: Constructor
        /// Parameter: none
        /// Method Input: none
        /// Return Value:none
        /// Date: 2/19/2018
        /// </summary>
        public LoginInterface()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method Name: btnLogin()
        /// Purpose: Checks if user and password are correct. 
        /// Parameter: none
        /// Method Input: none
        /// Return Value:none
        /// Date: 2/19/2018
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //IF THE USERNAME AND PASSWORD ARE CORRECT, THEN CONTINUE ON WITH THE PROGRAM
            if (txtUser.Text == "DrWoodcock" && txtPassword.Text =="panWobbie")
            {
                
                MainGUI mainGUI = new MainGUI();

                this.Visible = false;

                mainGUI.ShowDialog();

                this.Close();

            }
            else
            {
                lblStatus.Text = "Username or Password is Incorrect. Try Again.";

                txtPassword.Text = String.Empty;
            }
      

        }
    }
}
