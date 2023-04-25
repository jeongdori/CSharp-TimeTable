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
        DataSet dataSet = new DataSet();
        public Form1()
        {
            InitializeComponent();

        }


        public void Form_Load(object sender, EventArgs e)
        {


            if (File.Exists("TimeTableData.xml"))
            {
                dataSet.ReadXml("TimeTableData.xml");
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                List<Schedule> schedules = new List<Schedule>();
                schedules.Add(new Schedule { Time = Properties.Settings.Default.LoadStrNine, Mon = "", Tue = "", Wed = "", Thu = "", Fri = "" });
                schedules.Add(new Schedule { Time = Properties.Settings.Default.LoadStrTen, Mon = "", Tue = "", Wed = "", Thu = "", Fri = "" });
                schedules.Add(new Schedule { Time = Properties.Settings.Default.LoadStrEle, Mon = "", Tue = "", Wed = "", Thu = "", Fri = "" });
                schedules.Add(new Schedule { Time = Properties.Settings.Default.LoadStrTwe, Mon = "", Tue = "", Wed = "", Thu = "", Fri = "" });
                schedules.Add(new Schedule { Time = Properties.Settings.Default.LoadStrThi, Mon = "", Tue = "", Wed = "", Thu = "", Fri = "" });
                schedules.Add(new Schedule { Time = Properties.Settings.Default.LoadStrFou, Mon = "", Tue = "", Wed = "", Thu = "", Fri = "" });
                schedules.Add(new Schedule { Time = Properties.Settings.Default.LoadStrFif, Mon = "", Tue = "", Wed = "", Thu = "", Fri = "" });
                schedules.Add(new Schedule { Time = Properties.Settings.Default.LoadStrSix, Mon = "", Tue = "", Wed = "", Thu = "", Fri = "" });
                schedules.Add(new Schedule { Time = Properties.Settings.Default.LoadStrSev, Mon = "", Tue = "", Wed = "", Thu = "", Fri = "" });

                var serializer = new XmlSerializer(typeof(List<Schedule>));

                var writer = new StreamWriter("TimeTableData.xml");
                serializer.Serialize(writer, schedules);
                writer.Close();

                dataSet.ReadXml("TimeTableData.xml");
                dataGridView1.DataSource = dataSet.Tables[0];

            }



        }




        //셀 더블클릭 이벤트 : 셀에 내용 입력/수정
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];


                string? message = clickedCell.Value.ToString();

                using (var form = new Form())
                {

                    var newValue = new System.Windows.Forms.TextBox() { Text = message };
                    var okButton = new System.Windows.Forms.Button() { Text = "확인" };
                    var cancelButton = new System.Windows.Forms.Button() { Text = "취소" };

                    // 위치와 크기
                    System.Drawing.Point clickPoint = this.PointToClient(Cursor.Position);
                    form.StartPosition = FormStartPosition.Manual;
                    form.Location = new System.Drawing.Point(clickPoint.X + 50, clickPoint.Y + 50);
                    newValue.Location = new System.Drawing.Point(10, 10);
                    newValue.Size = new Size(200, 20);
                    okButton.Location = new System.Drawing.Point(10, 70);
                    okButton.Size = new Size(75, 23);
                    cancelButton.Location = new System.Drawing.Point(95, 70);
                    cancelButton.Size = new Size(75, 23);
                    form.Size = new Size(300, 150);


                    okButton.Click += (s, ev) =>
                    {
                        System.Data.DataTable dataTable = dataSet.Tables[0];
                        DataRow row = dataTable.Rows[e.RowIndex];
                        row[e.ColumnIndex] = newValue.Text;

                        dataSet.AcceptChanges();

                        dataSet.WriteXml("TimeTableData.xml");

                        form.Close();
                    };

                    cancelButton.Click += (s, ev) =>
                    {
                        form.Close();
                    };


                    form.Controls.Add(newValue);
                    form.Controls.Add(okButton);
                    form.Controls.Add(cancelButton);


                    form.ShowDialog();
                }

                //string? newValue = Microsoft.VisualBasic.Interaction.InputBox("강의명, 교수명 등을 입력하세요", "강의정보", message);

                //DataTable dataTable = dataSet.Tables[0];
                //DataRow row = dataTable.Rows[e.RowIndex];
                //row[e.ColumnIndex] = newValue;

                //dataSet.AcceptChanges();

                //dataSet.WriteXml("TimeTableData.xml");


                //clickedCell.Value = newValue;
            }
        }


        private void ExcelButtonClick(object sender, EventArgs e)
        {
            DataGridViewExcel excelClass = new DataGridViewExcel(dataGridView1);
            excelClass.ExportToExcelFor();


        }

        private void PrintButtonClick(object sender, EventArgs e)
        {
            DataGridViewPrinter printer = new DataGridViewPrinter(dataGridView1);
            printer.Print();


        }

        private void ExcelView_Click(object sender, EventArgs e)
        {
            DataGridViewExcel excelClass = new DataGridViewExcel(dataGridView1);
            excelClass.ExcelView();
        }

        private void ExcelImport_Click(object sender, EventArgs e)
        {
            DataGridViewExcel excelClass = new DataGridViewExcel(dataGridView1);
            excelClass.ExcelImport();
        }
    }
}