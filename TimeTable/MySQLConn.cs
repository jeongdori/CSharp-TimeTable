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
        DataGridView dataGridView1;
        public MySQLConn(DataGridView dataGridView1)
        {
            this.dataGridView1 = dataGridView1;
        }  

        public void ShowMySQL()
        {
            MySqlConnection con = new MySqlConnection(
                @"Server=csharpdbtest.ci7ruv8mn7ai.ap-northeast-2.rds.amazonaws.com;Database='timetable';Uid='admin';Pwd='40132010'; Allow Zero Datetime=True;");
            con.Open();

            string strSql = "select * from timeTable;";
            MySqlCommand cmd = new MySqlCommand(strSql, con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            con.Close();

        }
    }
}
