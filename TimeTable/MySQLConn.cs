using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TimeTable
{
    internal class MySQLConn
    {

        private string Server = "";
        private string Database = "";
        private string Uid = "";
        private string Pwd = "";

        DataGridView dataGridView1;
        public MySQLConn(DataGridView dataGridView1, string Server, string Database, string Uid, string Pwd)
        {
            this.dataGridView1 = dataGridView1;
            this.Server = Server;
            this.Database = Database;
            this.Uid = Uid;
            this.Pwd = Pwd;
        }

        public void ShowMySQL()
        {
            try { 
                MySqlConnection con = new MySqlConnection(
                    $"Server='{Server}';Database='{Database}';Uid='{Uid}';Pwd='{Pwd}'; Allow Zero Datetime=True;");
                con.Open();

                string strSql = "select * from timeTable;";
                MySqlCommand cmd = new MySqlCommand(strSql, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
