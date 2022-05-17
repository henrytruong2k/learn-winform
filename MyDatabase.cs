using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class MyDatabase
    {
        //data source
        private string strCon = @"Data Source=DESKTOP-6PBQEQF;Initial Catalog=mypos;Integrated Security=True";
        private SqlConnection sqlCon;

        public MyDatabase()
        {
            sqlCon = new SqlConnection(this.strCon);
        }

        public DataTable executeSqlCommand(string sqlCommand)
        {
            DataTable dtTable = new DataTable();
            try
            {
                this.sqlCon.Open();

                //create sqlAdapter
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand, this.sqlCon);
                dataAdapter.Fill(dtTable);

                this.sqlCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                dtTable = null;
            }
            return dtTable;
        }

    }
}
