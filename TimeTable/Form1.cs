using System;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

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
                    Point clickPoint = this.PointToClient(Cursor.Position);
                    form.StartPosition = FormStartPosition.Manual;
                    form.Location = new Point(clickPoint.X + 50, clickPoint.Y + 50);

                    var newValue = new TextBox() { Text = message };
                    var okButton = new Button() { Text = "확인" };
                    var cancelButton = new Button() { Text = "취소" };

                    // 각 컨트롤의 위치와 크기를 설정합니다.
                    newValue.Location = new Point(10, 10);
                    newValue.Size = new Size(200, 20);
                    okButton.Location = new Point(10, 70);
                    okButton.Size = new Size(75, 23);
                    cancelButton.Location = new Point(95, 70);
                    cancelButton.Size = new Size(75, 23);
                    form.Size = new Size(300, 150);


                    okButton.Click += (s, ev) =>
                    {
                        DataTable dataTable = dataSet.Tables[0];
                        DataRow row = dataTable.Rows[e.RowIndex];
                        row[e.ColumnIndex] = newValue.Text;

                        dataSet.AcceptChanges();

                        dataSet.WriteXml("TimeTableData.xml");
                        // 폼을 닫습니다.
                        form.Close();
                    };

                    cancelButton.Click += (s, ev) =>
                    {
                        // 폼을 닫습니다.
                        form.Close();
                    };

                    // 폼에 컨트롤을 추가합니다.
                    form.Controls.Add(newValue);
                    form.Controls.Add(okButton);
                    form.Controls.Add(cancelButton);

                    // 폼을 표시합니다.
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
            ExcelClass excel = new ExcelClass();
            excel.ExportToExcel(dataGridView1);
        }

        private void PrintButtonClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}