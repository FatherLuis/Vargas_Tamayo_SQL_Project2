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
    /// Class name: Database
    /// Class Author: Luis E. Vargas Tamayo
    /// Purpose of the class: Allows user to view the tables in the database, write, edit, and delete
    /// Date: 02/19/2018
    /// List of changes with dates: n/a
    /// Special Notes: n/a
    /// </summary>
    public partial class Database : Form
    {
        private mySQL myDatabase; //CLASS-VARIABLE OF CLASS MYSQL
        private string user; //CLASS-VARIABLE CONTAINS USERNAME
        private string pass; //CLASS-VARIABLE CONTAINS PASSWORD

        public Database(String username, String password)
        {
            InitializeComponent();
            myDatabase = new mySQL(username, password);

            user = username;
            pass = password;
        }

        /// <summary>
        /// Method Name: mnuEditViewFaculty()
        /// Purpose: Allows the user to view the Faculty Table
        /// Parameter: none
        /// Method Input: none
        /// Return Value: none
        /// Date: 02/19/2018
        /// </summary>
        private void mnuEditViewFaculty_Click(object sender, EventArgs e)
        {
            //GETS TABLE FROM DATABASE AND SHOWS IT IN THE DATAVIEWGRID
            dgvViewData.DataSource = myDatabase.ImportData("Faculty_Table");

            //DATAVIEWGRID IS NOW VISIBLE
            dgvViewData.Visible = true;
        }

        /// <summary>
        /// Method Name: mnuEditAddStudent()
        /// Purpose: Creates the form that allows user to enter information to database
        /// Parameter: none
        /// Method Input: none
        /// Return Value:none
        /// Date: 02/19/2018
        /// </summary>
        private void mnuEditAddStudent_Click(object sender, EventArgs e)
        {
            AddPerson frmStudent = new AddPerson(user,pass);


            //PLACES TEXT ON THE LABELS IN THE FORM
            frmStudent.Text = "Add Student";

            frmStudent.setTextLabelOne("Student ID");
            frmStudent.setTextLabelTwo("First Name");
            frmStudent.setTextLabelThree("Last Name");
            frmStudent.setTextLabelFour("Elementary School");
            frmStudent.setTextLabelFive("Middle School");
            frmStudent.setTextLabelSix("High School");

            frmStudent.setTextTextOne(GenerateID(1).ToString());

            //THIS FORM IS NOW INVISIBLE 
            this.Visible = false;

            //OPENS THE STUDENT FORM
            frmStudent.ShowDialog();

            //THIS FORM IS NOW VISIBLE
            this.Visible = true;

            //REFRESHES THE DATAVIEWGRID WITH THE STUDENT TABLE
            dgvViewData.DataSource = myDatabase.ImportData("Student_Table");

            //DATAVIEWGRID IS NOW VISIBLE
            dgvViewData.Visible = true;

        }
   
        /// <summary>
        /// Method Name: mnuEditAddFaculty
        /// Purpose: creates the form that allows user to enter information to the database
        /// Parameter: none
        /// Method Input: none
        /// Return Value: none
        /// Date: 02/19/2018
        /// </summary>
        private void mnuEditAddFaculty_Click(object sender, EventArgs e)
        {
            AddPerson frmFaculty = new AddPerson(user,pass);

            //PLACES TEXT ON THE LABELS IN THE FORM
            frmFaculty.Text = "Add Faculty";

            //SETS THE TEXT FOR THE LABELS IN THE FORM
            frmFaculty.setTextLabelOne("Faculty ID");
            frmFaculty.setTextLabelTwo("First Name");
            frmFaculty.setTextLabelThree("Last Name");
            frmFaculty.setTextLabelFour("School Attending");
            frmFaculty.setTextLabelFive("Department");
            frmFaculty.setTextLabelSix("Highest Degree");


            frmFaculty.setTextTextOne(GenerateID(4).ToString());

            //THIS FORM IS NOW NOT VISIBLE
            this.Visible = false;
            
            //OPENS FORM FOR FACULTY
            frmFaculty.ShowDialog();

            //THIS FORM IS NOW VISIBLE
            this.Visible = true;

            //REFRESHES THE DATAVIEWGRID WITH THE STUDENT TABLE
            dgvViewData.DataSource = myDatabase.ImportData("Faculty_Table");

            //DATAVIEWGRID IS NOW VISIBLE
            dgvViewData.Visible = true;

        }

        /// <summary>
        /// Method Name: mnuEditEditRow()
        /// Purpose: Allows user to edit a row in the database
        /// Parameter: none
        /// Method Input: none
        /// Return Value: none
        /// Date: 02/19/2018
        /// </summary>
        private void mnuEditEditRow_Click(object sender, EventArgs e)
        {
            //CHECKS IF A CELL WAS SELECTED
            if (dgvViewData.CurrentCell != null)
            {
                //GETS THE STRING REPRESENTATION IN THE FIRST CELL OF THE ROW SELECTED
                String ID = dgvViewData.CurrentRow.Cells[0].Value.ToString();

                AddPerson frmStudent = new AddPerson(user, pass);

                //IF THE ID STARTS WITH ONE, THEN EDIT IN THE STUDENT TABLE
                if (ID.StartsWith("1"))
                {
                    //SETS THE TEXT OF THE LABELS IN THE FORM
                    frmStudent.Text = "Edit Student";

                    frmStudent.setTextLabelOne("Student ID");
                    frmStudent.setTextLabelTwo("First Name");
                    frmStudent.setTextLabelThree("Last Name");
                    frmStudent.setTextLabelFour("Elementary School");
                    frmStudent.setTextLabelFive("Middle School");
                    frmStudent.setTextLabelSix("High School");



                    //THE ARRAY CONTAINS STRING INFORMATION FROM THE GIVEN ROW
                    String[] selectedRowData = myDatabase.GetRowData(ID, "Student_Table");

                    //SETS THE TEXT OF THE TEXTBOXES IN THE FORM
                    frmStudent.setTextTextOne(selectedRowData[0]);
                    frmStudent.setTextTextTwo(selectedRowData[1]);
                    frmStudent.setTextTextThree(selectedRowData[2]);
                    frmStudent.setTextTextFour(selectedRowData[3]);
                    frmStudent.setTextTextFive(selectedRowData[4]);
                    frmStudent.setTextTextSix(selectedRowData[5]);

                    //THIS FORM IS NOT NOT VISIBLE
                    this.Visible = false;

                    //OPENS A FORM TO EDIT SELECTED ROW
                    frmStudent.ShowDialog();

                    //THIS FORM IS NOW VISIBLE
                    this.Visible = true;

                    //UPDATES THE DATAVIEWGRID
                    dgvViewData.DataSource = myDatabase.ImportData("Student_Table");
                    dgvViewData.Visible = true;

                }
                //IF THE ID STARTS WITH FOUR, THEN EDIT IN THE FACULTY TABLE
                else if(ID.StartsWith("4"))
                {
                    //SETS THE TEXT OF THE LABELS IN THE FORM
                    frmStudent.Text = "Edit Faculty";

                    frmStudent.setTextLabelOne("Faculty ID");
                    frmStudent.setTextLabelTwo("First Name");
                    frmStudent.setTextLabelThree("Last Name");
                    frmStudent.setTextLabelFour("School");
                    frmStudent.setTextLabelFive("Department");
                    frmStudent.setTextLabelSix("Highest Degree");


                    //THE ARRAY CONTAINS STRING INFORMATION FROM THE GIVEN ROW
                    String[] selectedRowData = myDatabase.GetRowData(ID, "Faculty_Table");

                    //SETS THE TEXT OF THE TEXTBOXES IN THE FORM
                    frmStudent.setTextTextOne(selectedRowData[0]);
                    frmStudent.setTextTextTwo(selectedRowData[1]);
                    frmStudent.setTextTextThree(selectedRowData[2]);
                    frmStudent.setTextTextFour(selectedRowData[3]);
                    frmStudent.setTextTextFive(selectedRowData[4]);
                    frmStudent.setTextTextSix(selectedRowData[5]);

                    //THIS FORM IS NOW NOT VISIBLE
                    this.Visible = false;

                    //OPENS A FORM TO EDIT SELECTED ROW
                    frmStudent.ShowDialog();

                    //THIS FORM IS NOW VISIBLE
                    this.Visible = true;

                    //UPDATES THE DATAVIEWGRID
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

        /// <summary>
        /// Method Name: mnuEditDeleteRow()
        /// Purpose: Deletes selected row from the database
        /// Parameter: none
        /// Method Input: none
        /// Return Value:none
        /// Date: 02/19/2018
        /// </summary>
        private void mnuEditDeleteRow_Click(object sender, EventArgs e)
        {
            //CHECKS IF THERE IS A SELECTED ROW
            if (dgvViewData.CurrentCell != null)
            {
                //GETS THE STRING REPRESENTATION IN THE FIRST CELL OF THE ROW SELECTED
                String ID = dgvViewData.CurrentRow.Cells[0].Value.ToString();

                //IF THE ID STARTS WITH 1, THEN DELETE THE ROW FROM THE STUDENT TABLE
                if (ID.StartsWith("1"))
                {
                    myDatabase.DeleteRow(ID,"Student_Table");
                    dgvViewData.DataSource = myDatabase.ImportData("Student_Table");
                    dgvViewData.Visible = true;
                }
                //IF THE ID STARTS WITH A 4, THEN DELETE THE ROW FROM THE FACULTY TABLE
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

        /// <summary>
        /// Method Name: mnuEditViewStudent()
        /// Purpose: Allows the user to view the Student Table
        /// Parameter: none
        /// Method Input: none
        /// Return Value: none
        /// Date: 02/19/2018
        /// </summary>
        private void mnuEditViewStudent_Click(object sender, EventArgs e)
        {        
            dgvViewData.DataSource = myDatabase.ImportData("Student_Table");
            dgvViewData.Visible = true;

        }

        /// <summary>
        /// Method Name: mnuFileExit()
        /// Purpose: Closes the form;
        /// Parameter: none
        /// Method Input: none
        /// Return Value:none
        /// Date: 2/19/2018
        /// </summary>
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            //Close this form
            Close();
        }

        /// <summary>
        /// Method Name: GenerateID
        /// Purpose: Generates an ID number
        /// Parameter: int FirstNumber
        /// Method Input: none
        /// Return Value:none
        /// Date: 2/19/2018
        /// </summary>
        private int GenerateID(int FirstNumber)
        {
            int ID = 0;

            int init = 0;

            Random rand = new Random();

            if (FirstNumber == 1)
            {
                init = 100000;

                init += rand.Next(10000, 99999);


            }
            else if(FirstNumber == 4)
            {
                init = 400000;

                init += rand.Next(10000,99999);

            }

            ID = init;


            return ID;

        }

    }
}
