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
   

    public partial class AddPerson : Form
    {
        private mySQL SQL;

        public AddPerson(String username, String password)
        {
            InitializeComponent();
            SQL = new mySQL(username,password);

        }


        //////////////////////////////////////////////

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

        ///////////////////////////////////////////////

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            ////////////////
            //I SHOULD HAVE A METHOD THAT CHECKS THE ENTERED INFORMATION 
            ///////////////////////

            if (this.Text == "Add Faculty")
            {

                SQL.InsertDataFaculty(txtOne.Text, txtTwo.Text, txtThree.Text, txtFour.Text, txtFive.Text, txtSix.Text);

            }
            else if (this.Text == "Add Student")
            {

                SQL.InsertDataStudent(txtOne.Text, txtTwo.Text, txtThree.Text, txtFour.Text, txtFive.Text, txtSix.Text);

            }
            else if (this.Text == "Edit Student")
            {
                SQL.UpdateRow(txtOne.Text, txtTwo.Text, txtThree.Text, txtFour.Text, txtFive.Text, txtSix.Text, "Student_Table");

            }
            else if(this.Text == "Edit Faculty")
            {
                SQL.UpdateRow(txtOne.Text, txtTwo.Text, txtThree.Text, txtFour.Text, txtFive.Text, txtSix.Text, "Faculty_Table");
            }

            Close();




        }
        ///////////////////////////////////////////////








    }
}
