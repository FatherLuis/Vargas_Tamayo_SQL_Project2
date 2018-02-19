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

        /// <summary>
        /// Method Name: 
        /// Purpose: 
        /// Parameter: 
        /// Method Input: 
        /// Return Value:
        /// Date: 
        /// </summary>
        public mySQL(string Username, string Password)
        {
            strDatabase = "CTASV20R2DRW.tamuct.edu";
            databaseName = "Initial Catalog = Luis2";
            strUsername = "User ID = "+Username;
            strPassword = "Password =" + Password;
        }

        /// <summary>
        /// Method Name: 
        /// Purpose: 
        /// Parameter: 
        /// Method Input: 
        /// Return Value:
        /// Date: 
        /// </summary>
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

        /// <summary>
        /// Method Name: 
        /// Purpose: 
        /// Parameter: 
        /// Method Input: 
        /// Return Value:
        /// Date: 
        /// </summary>
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

        /// <summary>
        /// Method Name: 
        /// Purpose: 
        /// Parameter: 
        /// Method Input: 
        /// Return Value:
        /// Date: 
        /// </summary>
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

        /// <summary>
        /// Method Name: 
        /// Purpose: 
        /// Parameter: 
        /// Method Input: 
        /// Return Value:
        /// Date: 
        /// </summary>
        public String[] GetRowData(String ID,String table)
        {

            String[] strList = new String[6];


            String strConnection = String.Format("Data Source= {0}; {1}; {2}; {3};", strDatabase, databaseName, strUsername, strPassword);
            //"Data Source =CTASV20R2DRW.tamuct.edu; Initial Catalog = Luis2; User ID =******; Password = ******";

            SqlConnection con = null;

            try
            {
                con = new SqlConnection(strConnection);

                SqlCommand cmd = new SqlCommand(String.Format(
                    "SELECT *" +
                    "FROM[Luis2FirstAssignment].[db_owner].[{0}] " +
                    "WHERE Luis2FirstAssignment.[db_owner].[{0}].ID = {1} ",table,ID), con);


                    //String.Format("SELECT * " +
                    //                                "FROM [Luis2FirstAssignment].[db_owner].{0}" +
                    //                                "WHERE Luis2FirstAssignment.[db_owner].{1}.ID = {2}", table, table, ID), con);



                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (table == "Student_Table")
                {

                    while (reader.Read())
                    {

                        strList[0] = reader["ID"].ToString();
                        strList[1] = reader["First Name"].ToString();
                        strList[2] = reader["Last Name"].ToString();
                        strList[3] = reader["Elementary School"].ToString();
                        strList[4] = reader["Middle School"].ToString();
                        strList[5] = reader["High School"].ToString();
                    }

                    reader.Close();

                }
                else if (table == "Faculty_Table")
                {
                    while (reader.Read())
                    {

                        strList[0] = reader["ID"].ToString();
                        strList[1] = reader["First Name"].ToString();
                        strList[2] = reader["Last Name"].ToString();
                        strList[3] = reader["School"].ToString();
                        strList[4] = reader["Department"].ToString();
                        strList[5] = reader["Highest Degree"].ToString();
                    }

                    reader.Close();

                }
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());

            //  //  "CONNECTION BAD, TRY AGAIN LATER"
            //}
            finally
            {


                //CLOSE
                con.Close();


            }















            return strList;

        }

        /// <summary>
        /// Method Name: 
        /// Purpose: 
        /// Parameter: 
        /// Method Input: 
        /// Return Value:
        /// Date: 
        /// </summary>
        public void DeleteRow(String ID,String table)
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
                sqlCmd.CommandText = String.Format("DELETE " +
                                    "FROM [Luis2FirstAssignment].[db_owner].[{0}]" +
                                    "WHERE [Luis2FirstAssignment].[db_owner].[{1}].[ID] = {2} ", table,table, ID);


                con.Open();

                sqlCmd.ExecuteNonQuery();

            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("CONNECTION BAD, TRY AGAIN LATER");
            //}
            finally
            {


                //CLOSE
                con.Close();


            }

        }
       
        /// <summary>
        /// Method Name: 
        /// Purpose: 
        /// Parameter: 
        /// Method Input: 
        /// Return Value:
        /// Date: 
        /// </summary>
        public void UpdateRow(String ID, String txt2, String txt3, String txt4, String txt5, String txt6,String table)
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


                if (table == "Student_Table")
                {


                    sqlCmd.CommandText = String.Format("UPDATE [Luis2FirstAssignment].[db_owner].[Student_Table]" +
                                                     "SET [First Name] = '{1}',[Last Name]='{2}',[Elementary School]='{3}',[Middle School]='{4}',[High School]='{5}'" +
                                                     "WHERE ID = '{0}'",
                                                     ID, txt2, txt3, txt4, txt5, txt6);
                }
                else if (table == "Faculty_Table")
                {
                    sqlCmd.CommandText = String.Format("UPDATE [Luis2FirstAssignment].[db_owner].[Faculty_Table]" +
                                                     "SET [First Name]='{1}',[Last Name]='{2}',[School]='{3}',[Department]='{4}',[Highest Degreel]='{5}'" +
                                                     "WHERE ID ='{0}'S",
                                                     ID, txt2, txt3, txt4, txt5, txt6);
                }


                con.Open();

                sqlCmd.ExecuteNonQuery();

            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("CONNECTION BAD, TRY AGAIN LATER");
            //}
            finally
            {


                //CLOSE
                con.Close();


            }




        }



    }
}
