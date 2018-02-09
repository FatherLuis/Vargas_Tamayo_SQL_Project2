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



        private void mnuEditViewStudent_Click(object sender, EventArgs e)
        {
            dgvViewData.DataSource = myDatabase.ImportData("Student_Table");
            dgvViewData.Visible = true;

        }

        private void mnuEditViewFaculty_Click(object sender, EventArgs e)
        {
            dgvViewData.DataSource = myDatabase.ImportData("Faculty_Table");
            dgvViewData.Visible = true;
        }

        private void mnuEditAddStudent_Click(object sender, EventArgs e)
        {
            AddPerson frmStudent = new AddPerson();

            frmStudent.setTextLabelOne("Student ID");
            frmStudent.setTextLabelTwo("First Name");
            frmStudent.setTextLabelThree("Last Name");
            frmStudent.setTextLabelFour("Elementary School");
            frmStudent.setTextLabelFive("Middle School");
            frmStudent.setTextLabelSix("High School");

            frmStudent.ShowDialog();

        }

        private void mnuEditAddFaculty_Click(object sender, EventArgs e)
        {
            AddPerson frmFaculty = new AddPerson();

            frmFaculty.setTextLabelOne("Faculty ID");
            frmFaculty.setTextLabelTwo("First Name");
            frmFaculty.setTextLabelThree("Last Name");
            frmFaculty.setTextLabelFour("School Attending");
            frmFaculty.setTextLabelFive("Department");
            frmFaculty.setTextLabelSix("Highest Degree");

            frmFaculty.ShowDialog();
        }
    }
}
