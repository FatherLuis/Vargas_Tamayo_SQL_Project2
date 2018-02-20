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
    /// Class name: AddPerson
    /// Class Author: Luis E. Vargas Tamayo
    /// Purpose of the class: Allows user to insert and edit information from the database
    /// Date: 02/19/2018
    /// List of changes with dates: n/a
    /// Special Notes: n/a
    /// </summary>
    public partial class AddPerson : Form
    {
        private mySQL SQL; //CLASS-VARIABLE OF CLASS MYSQL

        /// <summary>
        /// Method Name:AddPerson()
        /// Purpose: Constructor
        /// Parameter: String username, password
        /// Method Input: initializeComponents()
        /// Return Value: none
        /// Date: 02/19/2018
        /// </summary>
        public AddPerson(String username, String password)
        {
            InitializeComponent();
            SQL = new mySQL(username,password);

        }


        /// <summary>
        /// Purpose: Sets the text for label
        /// Parameter: String text
        /// Method Input: none  
        /// Return Value: none
        /// Date: 02/19/2018
        /// </summary>
        public void setTextLabelOne(string text)
        {
            lblOne.Text = text;
        }
        public void setTextLabelTwo(string text)
        {
            lblTwo.Text = text;
        }
        public void setTextLabelThree(string text)
        {
            lblThree.Text = text;
        }
        public void setTextLabelFour(string text)
        {
            lblFour.Text = text;
        }
        public void setTextLabelFive(string text)
        {
            lblFive.Text = text;
        }
        public void setTextLabelSix(string text)
        {
            lblSix.Text = text;
        }


        /// <summary>
        /// Purpose: Sets the text for textbox
        /// Parameter: String text
        /// Method Input: none  
        /// Return Value: none
        /// Date: 02/19/2018
        /// </summary>
        public void setTextTextOne(string text)
        {
            txtOne.Text = text;
        }
        public void setTextTextTwo(string text)
        {
            txtTwo.Text = text;
        }
        public void setTextTextThree(string text)
        {
            txtThree.Text = text;
        }
        public void setTextTextFour(string text)
        {
            txtFour.Text = text;
        }
        public void setTextTextFive(string text)
        {
            txtFive.Text = text;
        }
        public void setTextTextSix(string text)
        {
            txtSix.Text = text;
        }

        /// <summary>
        /// Method Name: btnSave()
        /// Purpose: Saves inputted information from the user to the database
        /// Parameter: none
        /// Method Input: SQL.InsertDataFaculty,SQL.InserDataStudent, SQL.UpdateRow()
        /// Return Value:
        /// Date: 02/19/2018
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            ////////////////
            //I SHOULD HAVE A METHOD THAT CHECKS THE ENTERED INFORMATION 
            ///////////////////////

            if (isfilled())
            {

                if (this.Text == "Add Faculty")
                {
                    //ADDS A NEW ROW IN THE FACULTY TABLE
                    SQL.InsertDataFaculty(txtOne.Text, txtTwo.Text, txtThree.Text, txtFour.Text, txtFive.Text, txtSix.Text);

                }
                else if (this.Text == "Add Student")
                {
                    //ADDS A NEW ROW IN THE STUDENT TABLE
                    SQL.InsertDataStudent(txtOne.Text, txtTwo.Text, txtThree.Text, txtFour.Text, txtFive.Text, txtSix.Text);

                }
                else if (this.Text == "Edit Student")
                {
                    //UPDATES A ROW IN THE STUDENT TABLE
                    SQL.UpdateRow(txtOne.Text, txtTwo.Text, txtThree.Text, txtFour.Text, txtFive.Text, txtSix.Text, "Student_Table");

                }
                else if (this.Text == "Edit Faculty")
                {
                    //UPDATES A ROW IN THE FACULTY TABLE
                    SQL.UpdateRow(txtOne.Text, txtTwo.Text, txtThree.Text, txtFour.Text, txtFive.Text, txtSix.Text, "Faculty_Table");
                }

                //CLOSES THE FORM
                Close();
            }
            else
            {
                txtStatus.Text = "There are blank textboxes";

            }
        }

        /// <summary>
        /// Method Name: btnCancel()
        /// Purpose: closes form
        /// Parameter: none
        /// Method Input: none
        /// Return Value: none
        /// Date: 02/19/2018
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //CLOSE FORM
            this.Close();
        }



        private Boolean isfilled()
        {
            if (txtTwo.Text != String.Empty && txtThree.Text != String.Empty)
            {
                if (txtFour.Text != String.Empty && txtFive.Text != String.Empty)
                {

                    if (txtSix.Text != String.Empty)
                    {
                        return true;
                    }
                }
            }

            return false; ;
        }
    }
}
