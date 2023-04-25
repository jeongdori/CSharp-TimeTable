using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace TimeTable
{
    internal class DataGridViewExcel
    {

        private DataGridView dataGridView1;

        public DataGridViewExcel(DataGridView dataGridView1)
        {
            this.dataGridView1 = dataGridView1;
        }


        //반복문으로 셀 데이터를 엑셀에 입력
        public void ExportToExcelFor()
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


            workbook.SaveAs($"DataGridViewExport{System.DateTime.Now}.xlsx", Excel.XlFileFormat.xlOpenXMLWorkbook);

            excelApp.Quit();

        }

        //셀 전체 복사 후 엑셀에 붙여넣기
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


        //셀 데이터 엑셀로 실행
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

        //엑셀 파일 불러오기
        public void ExcelImport()
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.Title = "Select an Excel file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                    try
                    {
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                    // Read Excel file using ExcelDataReader
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
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

                            // 프로그램 로컬 데이터 저장
                            DataSet dataSet = new DataSet();
                            dataSet.Tables.Add((dataGridView1.DataSource as System.Data.DataTable).Copy());
                            dataSet.WriteXml("TimeTableData.xml", XmlWriteMode.WriteSchema);
                            

                        }
                    }
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
            }
        }



    }
}

