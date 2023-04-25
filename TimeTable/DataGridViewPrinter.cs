using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TimeTable
{
    internal class DataGridViewPrinter
    {
        private DataGridView dataGridView1;

        public DataGridViewPrinter(DataGridView dataGridView1)
        {
            this.dataGridView1 = dataGridView1;
        }

        public void Print()
        {
            // 인쇄 대화 상자 생성
            PrintDialog printDialog = new PrintDialog();

            // 인쇄 작업 실행 여부 확인
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // PrintDocument 객체 생성 및 설정
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrinterSettings = printDialog.PrinterSettings;
                printDocument.DefaultPageSettings.Landscape = true;
                printDocument.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);

                // PrintPage 이벤트 핸들러 등록
                printDocument.PrintPage += new PrintPageEventHandler(PrintPage);

                // 인쇄 작업 실행
                printDocument.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            

            // 브러시 생성
            Brush brush = new SolidBrush(dataGridView1.DefaultCellStyle.ForeColor);

            
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText, dataGridView1.Font, brush, new RectangleF(dataGridView1.GetColumnDisplayRectangle(i, true).Location, new SizeF(dataGridView1.Columns[i].Width, dataGridView1.ColumnHeadersHeight * 1.5f)));
            }

           
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[j].Value.ToString(), dataGridView1.Font, brush, new RectangleF(dataGridView1.GetColumnDisplayRectangle(j, true).Location.X, dataGridView1.GetRowDisplayRectangle(i, true).Location.Y, dataGridView1.Columns[j].Width, dataGridView1.Rows[i].Height), StringFormat.GenericDefault);
                }
            }
        }

    }
}
