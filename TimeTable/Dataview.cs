using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable
{
    internal class Dataview
    {
        private DataGridView dataGridView1;

        public Dataview(DataGridView dataGridView1)
        {
            this.dataGridView1 = dataGridView1;
        }


        public void SaturdayView()
        {

            if(dataGridView1.Columns.Contains("토"))
            {
                Console.WriteLine("토 있다");
                Console.WriteLine(!dataGridView1.Columns["토"].Visible);
                dataGridView1.Columns["토"].Visible = !dataGridView1.Columns["토"].Visible;
            }
            else
            {
                Console.WriteLine("토 없다");
                dataGridView1.Columns.Add("토", "토");
                dataGridView1.Columns["토"].Visible = true;
            }

        }


    }
}
