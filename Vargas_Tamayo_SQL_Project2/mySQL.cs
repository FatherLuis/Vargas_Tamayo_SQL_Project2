using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

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
            databaseName = "databaseName=Luis2FirstAssigment";
            strUsername = Username;
            strPassword = Password;
        }

        public DataTable ImportData(string table)
        {
            //"jdbc:sqlserver://CTASV20R2DRW.tamuct.edu;databaseName=INVENTORY;user=Luisvargas;password=Tamayo005;"
            //INTEGRATED SECURITY 

            //DataSource=CTASV20R2DRW.tamuct.edu;InitialCatalog=Luis2;UserID=Luis2;Password=******;
            String strConnection = "DataSource={0}; + {1}; +{2}; +{3};", strDatabase,databaseName,strUserName,strPassword;

            SqlConnection con = new SqlConnection(strConnection);

            DataTable dtRecord;

            try
            {


                con = new SqlConnection(strConnection);

                con.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Select* FROM" + table;
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
    }
}
