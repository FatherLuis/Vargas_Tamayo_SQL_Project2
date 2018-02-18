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
        private string user;
        private string pass;

        public Database(String username, String password)
        {
            InitializeComponent();
            myDatabase = new mySQL(username, password);

            user = username;
            pass = password;
        }


        private void mnuEditViewFaculty_Click(object sender, EventArgs e)
        {
            dgvViewData.DataSource = myDatabase.ImportData("Faculty_Table");
            dgvViewData.Visible = true;
        }

        private void mnuEditAddStudent_Click(object sender, EventArgs e)
        {
            AddPerson frmStudent = new AddPerson(user,pass);

            frmStudent.Text = "Add Student";

            frmStudent.setTextLabelOne("Student ID");
            frmStudent.setTextLabelTwo("First Name");
            frmStudent.setTextLabelThree("Last Name");
            frmStudent.setTextLabelFour("Elementary School");
            frmStudent.setTextLabelFive("Middle School");
            frmStudent.setTextLabelSix("High School");

            frmStudent.ShowDialog();
            dgvViewData.DataSource = myDatabase.ImportData("Student_Table");
            dgvViewData.Visible = true;

        }

        private void mnuEditAddFaculty_Click(object sender, EventArgs e)
        {
            AddPerson frmFaculty = new AddPerson(user,pass);

            frmFaculty.setTextLabelOne("Faculty ID");
            frmFaculty.setTextLabelTwo("First Name");
            frmFaculty.setTextLabelThree("Last Name");
            frmFaculty.setTextLabelFour("School Attending");
            frmFaculty.setTextLabelFive("Department");
            frmFaculty.setTextLabelSix("Highest Degree");

            frmFaculty.ShowDialog();
        }

        private void mnuEditEditRow_Click(object sender, EventArgs e)
        {
            if (dgvViewData.CurrentCell != null)
            {
                String ID = dgvViewData.CurrentRow.Cells[0].Value.ToString();

                AddPerson frmStudent = new AddPerson(user, pass);


                if (ID.StartsWith("1"))
                {

                    frmStudent.Text = "Edit Student";

                    frmStudent.setTextLabelOne("Student ID");
                    frmStudent.setTextLabelTwo("First Name");
                    frmStudent.setTextLabelThree("Last Name");
                    frmStudent.setTextLabelFour("Elementary School");
                    frmStudent.setTextLabelFive("Middle School");
                    frmStudent.setTextLabelSix("High School");




                    String[] selectedRowData = myDatabase.GetRowData(ID, "Student_Table");

                    frmStudent.setTextTextOne(selectedRowData[0]);
                    frmStudent.setTextTextTwo(selectedRowData[1]);
                    frmStudent.setTextTextThree(selectedRowData[2]);
                    frmStudent.setTextTextFour(selectedRowData[3]);
                    frmStudent.setTextTextFive(selectedRowData[4]);
                    frmStudent.setTextTextSix(selectedRowData[5]);

                    frmStudent.ShowDialog();

                    dgvViewData.DataSource = myDatabase.ImportData("Student_Table");
                    dgvViewData.Visible = true;

                }
                else if(ID.StartsWith("4"))
                {
                    frmStudent.Text = "Edit Faculty";

                    frmStudent.setTextLabelOne("Faculty ID");
                    frmStudent.setTextLabelTwo("First Name");
                    frmStudent.setTextLabelThree("Last Name");
                    frmStudent.setTextLabelFour("School");
                    frmStudent.setTextLabelFive("Department");
                    frmStudent.setTextLabelSix("Highest Degree");




                    String[] selectedRowData = myDatabase.GetRowData(ID, "Faculty_Table");

                    frmStudent.setTextTextOne(selectedRowData[0]);
                    frmStudent.setTextTextTwo(selectedRowData[1]);
                    frmStudent.setTextTextThree(selectedRowData[2]);
                    frmStudent.setTextTextFour(selectedRowData[3]);
                    frmStudent.setTextTextFive(selectedRowData[4]);
                    frmStudent.setTextTextSix(selectedRowData[5]);

                    frmStudent.ShowDialog();

                    dgvViewData.DataSource = myDatabase.ImportData("Faculty_Table");
                    dgvViewData.Visible = true;
                }





            }
            else if(dgvViewData.Visible != true)
            {
                MessageBox.Show("Select a table(s) to view, then try again");
            }
            else
            {
                MessageBox.Show("Select the row you would like to edit");
            }

        }

        private void mnuEditDeleteRow_Click(object sender, EventArgs e)
        {
            if (dgvViewData.CurrentCell != null)
            {

                String ID = dgvViewData.CurrentRow.Cells[0].Value.ToString();

                if (ID.StartsWith("1"))
                {
                    myDatabase.DeleteRow(ID,"Student_Table");
                    dgvViewData.DataSource = myDatabase.ImportData("Student_Table");
                    dgvViewData.Visible = true;
                }

                else if (ID.StartsWith("4"))
                {
                    myDatabase.DeleteRow(ID,"Faculty_Table");
                    dgvViewData.DataSource = myDatabase.ImportData("Faculty_Table");
                    dgvViewData.Visible = true;

                }
            }
            else
            {
                MessageBox.Show("Select the row you would like to delete");
            }


        }

        private void mnuEditViewStudent_Click(object sender, EventArgs e)
        {        
            dgvViewData.DataSource = myDatabase.ImportData("Student_Table");
            dgvViewData.Visible = true;

        }
    }
}
