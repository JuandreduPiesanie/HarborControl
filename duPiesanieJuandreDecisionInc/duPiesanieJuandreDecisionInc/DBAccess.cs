using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duPiesanieJuandreDecisionInc
{
    class DBAccess
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private string qry;

        //Data Source=JUANDREPC;Initial Catalog=DecisionIncAssessment;Integrated Security=True
        public DBAccess()
        {
            connection.DataSource = "JUANDREPC";
            connection.InitialCatalog = "DecisionIncAssessment";
            connection.IntegratedSecurity = true;
        }

        public DataSet ReadData(string tableName)
        {
            DataSet rawData = new DataSet();
            conn = new SqlConnection(connection.ToString());
            qry = string.Format("SELECT * FROM {0}", tableName);
            try
            {
                //connects to server
                conn.Open();
                if (conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("A connection to the database can't be established.");
                }
                adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(rawData, SchemaType.Source, tableName);//where, schema type, newtablename
                adapter.Fill(rawData, tableName);//fills the data

            }
            catch (SqlException se)//connection
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return rawData;
        }

        public DataSet getLastRow(string tableName)
        {
            DataSet rawData = new DataSet();
            conn = new SqlConnection(connection.ToString());
            qry = string.Format("SELECT TOP 1 * FROM {0} ORDER BY weatherID DESC", tableName);
            try
            {
                //connects to server
                conn.Open();
                if (conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("A connection to the database can't be established.");
                }
                adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(rawData, SchemaType.Source, tableName);//where, schema type, newtablename
                adapter.Fill(rawData, tableName);//fills the data

            }
            catch (SqlException se)//connection
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return rawData;
        }

        public void InsertWindDetails(float windspeed, DateTime timelogged)
        {            
            qry = string.Format("INSERT INTO[dbo].[WindDetails]([WindSpeed],[Time]) VALUES('{0}', '{1}')",windspeed, timelogged);
            ExecuteSQL();
        }

        private void ExecuteSQL()
        {
            conn = new SqlConnection(connection.ToString());
            try
            {
                conn.Open();
                command = new SqlCommand(qry, conn);
                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                //still need to change
                MessageBox.Show(se.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
