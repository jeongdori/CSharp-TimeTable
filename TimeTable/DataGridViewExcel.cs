using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Windows.Forms.Design;

namespace TimeTable
{
    internal class DataGridViewExcel
    {

        private DataGridView dataGridView1;

        public DataGridViewExcel(DataGridView dataGridView1)
        {
            this.dataGridView1 = dataGridView1;
        }


        //엑셀 파일 불러오기
        public string[] ExcelImport()
        {
            OpenFileDialog openFile = openFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                    // Read Excel file using ExcelDataReader
                    using (var stream = File.Open(openFile.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            var result = reader.AsDataSet(new ExcelDataSetConfiguration() //데이터셋 변환하기
                            {
                                ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                                {
                                    //Column 자동생성을 무시하고 첫번째 행을 열로 자동 지정.
                                    UseHeaderRow = true,
                                }
                            });

                            dataGridView1.DataSource = result.Tables[0]; //엑셀파일의 첫번째 Table을 가져온다


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {

            }
            string fileNameOnly = Path.GetFileName(openFile.FileName);
            string[] fileimpor = { openFile.FileName, fileNameOnly };

            return fileimpor;
        }


        //수정 내용 로드한 파일에 그대로 저장
        public void SaveExcelFile(string fileName)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(fileName);
            Excel.Worksheet worksheet = workbook.Sheets[1];

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {

                    worksheet.Cells[row + 2, col + 1] = dataGridView1.Rows[row].Cells[col].Value.ToString();

                }
            }

            workbook.Save();
            workbook.Close();
            excelApp.Quit();

            //함수를 실행할 때마다 백그라운드 프로세스에 계속 엑셀이 추가됨
            //해결방안 : COM 객체 해제, 가비지 콜렉터
            
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(excelApp);

            GC.Collect();
        }


        //엑셀 파일 내보내기 반복문
        public void ExportToExcelFor(string FileName)
        {
            SaveFileDialog SaveFile = saveFileDialog(); 

            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet Worksheet = (Excel.Worksheet)workbook.ActiveSheet;

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    Worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                    workbook.SaveAs(FileName, Excel.XlFileFormat.xlOpenXMLWorkbook);
                    MessageBox.Show("저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    excelApp.Quit();
            }

            


        }

        //엑셀 파일 내보내기 클립보드
        public void ExportToExcelClipboard()
        {

            dataGridView1.SelectAll();
            DataObject CopyData = dataGridView1.GetClipboardContent();
            Object MisedData = System.Reflection.Missing.Value;
            if (CopyData != null) { Clipboard.SetDataObject(CopyData); }

            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;
            Excel.Workbook workbook = excelApp.Workbooks.Add(MisedData);
            Excel.Worksheet Worksheet = (Excel.Worksheet)workbook.ActiveSheet;
            Excel.Range range = (Excel.Range)Worksheet.Cells[1, 1];
            range.Select();

            Worksheet.PasteSpecial(range, Type.Missing, true);

            workbook.SaveAs("TimeTable.xlsx");
            excelApp.Save();
        }


        //셀 데이터 엑셀로 보기
        public void ExcelView()
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet Worksheet = (Excel.Worksheet)workbook.ActiveSheet;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                Worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
        }



        public OpenFileDialog openFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|All files (*.*)|*.*";
            openFileDialog.Title = "Select an Excel file";
            return openFileDialog;
        }

        public SaveFileDialog saveFileDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xlsm;*.xls|All files (*.*)|*.*";
            saveFileDialog.Title = "Save As";

            return saveFileDialog;
        }


    }
}

