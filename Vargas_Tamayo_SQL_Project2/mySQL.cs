using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Vargas_Tamayo_SQL_Project2
{
    class mySQL
    {

        private static string strDatabase;
        private static string databaseName;
        private static string strUsername;
        private static string strPassword;

        public mySQL(string Username, string Password)
        {
            strDatabase = "CTASV20R2DRW.tamuct.edu";
            databaseName = "Initial Catalog = Luis2";
            strUsername = "User ID = "+Username;
            strPassword = "Password =" + Password;
        }

        public DataTable ImportData(string table)
        {


            String strConnection = String.Format("Data Source= {0}; {1}; {2}; {3};", strDatabase, databaseName, strUsername, strPassword);
            //"Data Source =CTASV20R2DRW.tamuct.edu; Initial Catalog = Luis2; User ID =******; Password = ******";


            SqlConnection con = new SqlConnection(strConnection);

            DataTable dtRecord;

            try
            {


                con = new SqlConnection(strConnection);

                con.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Select* FROM Luis2FirstAssignment.db_owner." + table;
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);

                // “Open” the connection(this is the first time it actually
                //contacts the database server)

                //cnMyConn.Open();

                //CREATE THE COMMAND OBJECT NOW
                //SqlCommand sqlMyCommand = new SqlCommand(strCommand, cnMyConn);

                //CREATE THE RESULT SET
                //rsMyRS = sqlMyCommand.ExecuteReader();

                //OUTPUT WHAT YOU GOT
                //while (rsMyRS.Read())
                //{
                //    WRITE OUT THE FIRST ORDINAL NUMBERS HERE
                //    COLUMNS.WE CAN ALSO REFER TO THE COLUMN BY NAME
                //    Console.WriteLine(rsMyRS[*Name *]);
                //}
            }
            finally
            {
                //CLOSE
                con.Close();

            }

            return dtRecord;


        }

        public void InsertDataStudent(String ID, String FirstName, String LastName, String ElemSchool, String MidSchool, String HighSchool)
        {


            String strConnection = String.Format("Data Source= {0}; {1}; {2}; {3};", strDatabase, databaseName, strUsername, strPassword);
            //"Data Source =CTASV20R2DRW.tamuct.edu; Initial Catalog = Luis2; User ID =******; Password = ******";

            SqlConnection con = null;
            try
            {
                con = new SqlConnection(strConnection);

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = String.Format("INSERT INTO [Luis2FirstAssignment].[db_owner].[Student_Table]" +
                                                 "([ID],[First Name],[Last Name],[Elementary School],[Middle School],[High School])" +
                                                 "VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                                                 ID, FirstName, LastName, ElemSchool, MidSchool, HighSchool);


                con.Open();

                sqlCmd.ExecuteNonQuery();


                // “Open” the connection(this is the first time it actually
                //contacts the database server)

                //cnMyConn.Open();

                //CREATE THE COMMAND OBJECT NOW
                //SqlCommand sqlMyCommand = new SqlCommand(strCommand, cnMyConn);

                //CREATE THE RESULT SET
                //rsMyRS = sqlMyCommand.ExecuteReader();

                //OUTPUT WHAT YOU GOT
                //while (rsMyRS.Read())
                //{
                //    WRITE OUT THE FIRST ORDINAL NUMBERS HERE
                //    COLUMNS.WE CAN ALSO REFER TO THE COLUMN BY NAME
                //    Console.WriteLine(rsMyRS[*Name *]);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("CONNECTION BAD, TRY AGAIN LATER");
            }
            finally
            {
                

                //CLOSE
                con.Close();


            }







        }

        public void InsertDataFaculty(String ID, String FirstName, String LastName, String School, String Department, String HighestDegree)
        {


            String strConnection = String.Format("Data Source= {0}; {1}; {2}; {3};", strDatabase, databaseName, strUsername, strPassword);
            //"Data Source =CTASV20R2DRW.tamuct.edu; Initial Catalog = Luis2; User ID =******; Password = ******";

            SqlConnection con = null;
            try
            {
                con = new SqlConnection(strConnection);

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = String.Format("INSERT INTO [Luis2FirstAssignment].[db_owner].[Faculty_Table]" +
                                                 "([ID],[First Name],[Last Name],[School],[Department],[Highest Degreel])" +
                                                 "VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                                                 ID, FirstName, LastName, School, Department, HighestDegree);


                con.Open();

                sqlCmd.ExecuteNonQuery();


                // “Open” the connection(this is the first time it actually
                //contacts the database server)

                //cnMyConn.Open();

                //CREATE THE COMMAND OBJECT NOW
                //SqlCommand sqlMyCommand = new SqlCommand(strCommand, cnMyConn);

                //CREATE THE RESULT SET
                //rsMyRS = sqlMyCommand.ExecuteReader();

                //OUTPUT WHAT YOU GOT
                //while (rsMyRS.Read())
                //{
                //    WRITE OUT THE FIRST ORDINAL NUMBERS HERE
                //    COLUMNS.WE CAN ALSO REFER TO THE COLUMN BY NAME
                //    Console.WriteLine(rsMyRS[*Name *]);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("CONNECTION BAD, TRY AGAIN LATER");
            }
            finally
            {


                //CLOSE
                con.Close();


            }







        }




    }
}
