using ExcelDataReader;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelClass = TimeTable.DataGridViewExcel;


namespace TimeTable
{
    public partial class Form1 : Form
    {
        //load한 파일정보
        string[]? fileimpor;

        public Form1()
        {
            InitializeComponent();

        }




        //셀 더블클릭 이벤트 : 셀에 내용 입력/수정
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string? message = "";
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (clickedCell.Value != null && clickedCell.Value.GetType() != typeof(System.Drawing.Bitmap))
                {
                    message = clickedCell.Value.ToString();
                }


                using (var form = new Form())
                {

                    var newValue = new System.Windows.Forms.TextBox() { Text = message };
                    var backColor = new System.Windows.Forms.Button() { Text = "색변경" };
                    var LoadImage = new System.Windows.Forms.Button() { Text = "이미지" };
                    var okButton = new System.Windows.Forms.Button() { Text = "확인" };
                    var cancelButton = new System.Windows.Forms.Button() { Text = "취소" };

                    // 위치와 크기
                    System.Drawing.Point clickPoint = this.PointToClient(Cursor.Position);
                    form.StartPosition = FormStartPosition.Manual;
                    form.Location = new System.Drawing.Point(clickPoint.X + 50, clickPoint.Y + 50);
                    newValue.Location = new System.Drawing.Point(10, 10);
                    newValue.Size = new Size(100, 23);
                    backColor.Location = new System.Drawing.Point(20, 70);
                    backColor.Size = new Size(55, 23);
                    LoadImage.Location = new System.Drawing.Point(80, 70);
                    LoadImage.Size = new Size(55, 23);
                    okButton.Location = new System.Drawing.Point(140, 70);
                    okButton.Size = new Size(55, 23);
                    cancelButton.Location = new System.Drawing.Point(200, 70);
                    cancelButton.Size = new Size(55, 23);
                    form.Size = new Size(300, 150);


                    backColor.Click += (s, ev) =>
                    {
                        DataGridViewColor dataGridViewColor = new DataGridViewColor(dataGridView1);
                        dataGridViewColor.CellColorChange(clickedCell);

                        form.Close();
                    };


                    LoadImage.Click += (s, ev) =>
                    {
                        ImageInsert imageinsert = new ImageInsert(dataGridView1);
                        imageinsert.LoadImage(clickedCell);

                        form.Close();
                    };

                    okButton.Click += (s, ev) =>
                    {
                        System.Data.DataTable dataTable = (DataTable)dataGridView1.DataSource;
                        DataRow row = dataTable.Rows[e.RowIndex];
                        row[e.ColumnIndex] = newValue.Text;

                        //dataSet.AcceptChanges();

                        //dataSet.WriteXml("TimeTableData.xml");

                        form.Close();
                    };

                    cancelButton.Click += (s, ev) =>
                    {
                        form.Close();
                    };


                    form.Controls.Add(newValue);
                    form.Controls.Add(okButton);
                    form.Controls.Add(cancelButton);
                    form.Controls.Add(LoadImage);
                    form.Controls.Add(backColor);


                    form.ShowDialog();
                }

            }
        }




        //엑셀파일 로드
        private void ExcelImport_Click(object sender, EventArgs e)
        {
            DataGridViewExcel excelClass = new DataGridViewExcel(dataGridView1);
            fileimpor = excelClass.ExcelImport();
        }

        //저장
        private void ExcelSaveButtonClick(object sender, EventArgs e)
        {
            if (fileimpor != null)
            {
                DataGridViewExcel excelClass = new DataGridViewExcel(dataGridView1);
                excelClass.SaveExcelFile(fileimpor[0]);
            }
        }

        //새로 저장
        private void ExcelSaveAsButtonClick(object sender, EventArgs e)
        {
            if (fileimpor != null)
            {
                DataGridViewExcel excelClass = new DataGridViewExcel(dataGridView1);
                excelClass.ExportToExcelFor(fileimpor[1]);
            }

        }

        //엑셀로 보기
        private void ExcelView_Click(object sender, EventArgs e)
        {
            DataGridViewExcel excelClass = new DataGridViewExcel(dataGridView1);
            excelClass.ExcelView();
        }

        //인쇄
        private void PrintButtonClick(object sender, EventArgs e)
        {
            DataGridViewPrinter printer = new DataGridViewPrinter(dataGridView1);
            printer.Print();

        }
        //DB 데이터 불러오기
        private void DBConnClick(object sender, EventArgs e)
        {
            MySQLConn mySQLConn = new MySQLConn(dataGridView1, DBaddress.Text, DBname.Text, DBid.Text, DBpw.Text);
            mySQLConn.ShowMySQL();
        }

        private void BackColorChangeClick(object sender, EventArgs e)
        {
            DataGridViewColor dataGridViewColor = new DataGridViewColor(dataGridView1);
            dataGridViewColor.BackColorChange();

        }

        private void SaturdayViewClick(object sender, EventArgs e)
        {
            Dataview dataview = new Dataview(dataGridView1);
            dataview.SaturdayView();
        }
    }
}