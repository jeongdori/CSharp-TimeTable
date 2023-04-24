using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TimeTable
{
    internal class ExcelClass
    {


        public void ExportToExcel(DataGridView dataGridView1)
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet Worksheet = (Excel.Worksheet)workbook.ActiveSheet;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    Worksheet.Cells[i, j] = dataTable.Rows[i][j].ToString;
                }

            }
            workbook.SaveAs("TimeTable.xlsx");
            excelApp.Save(); 
        }
    }
}
