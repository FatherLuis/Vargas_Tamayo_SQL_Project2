using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Vargas_Tamayo_SQL_Project2
{
    class mySQL
    {

        static void SQL()
        {

            //CREATE SOME BASE STRINGS SO THAT YOU CAN LOOK AT THESE
            //SEPARATELY FROM THE COMMANDS THEY RUN IN

            //INTEGRATED SECURITY - NEXT LINE SHOULD BE UNCOMMENTED
            String strConnect = " ";
            //“Data Source=(local);Initial Catalog=master;Integrated Security=SSPI”;

            // SQL SECURITY

            //string strConnect = “Data Source=(local);Initial Catalog=master;User Id=sa;Password=MyPass”;



            string strCommand = " SELECT Name, database_id as ID FROM sys.databases";
            SqlDataReader rsMyRS = null;
            SqlConnection cnMyConn = new SqlConnection(strConnect);


            try
            {   // “Open” the connection (this is the first time it actually   
                // contacts the database server)

                cnMyConn.Open();

                //CREATE THE COMMAND OBJECT NOW
                SqlCommand sqlMyCommand = new SqlCommand(strCommand, cnMyConn);

                //CREATE THE RESULT SET
                rsMyRS = sqlMyCommand.ExecuteReader();

                //OUTPUT WHAT YOU GOT
                while (rsMyRS.Read())
                {
                    //WRITE OUT THE FIRST ORDINAL NUMBERS HERE
                    //COLUMNS. WE CAN ALSO REFER TO THE COLUMN BY NAME
                    //Console.WriteLine(rsMyRS[*Name *]);
                }
            }
            finally
            {
                //CLOSE
                cnMyConn.Close();

            }

        }
    }
}
