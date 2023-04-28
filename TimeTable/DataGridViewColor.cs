using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Pwm;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Drawing.Imaging;

namespace TimeTable
{
    internal class DataGridViewColor
    {
        DataGridView dataGridView1;
      
        public DataGridViewColor(DataGridView dataGridView1)
        {
            this.dataGridView1 = dataGridView1;
        }





    //전체 배경색 변경 ==> 현재 검색결과까지는 바인딩된 데이터라 불가능한듯?
    public void BackColorChange()
        {
            ColorDialog colorDialog1 =  new ColorDialog();
            colorDialog1.ShowHelp = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.BackgroundColor = colorDialog1.Color;
            }
        }

        //선택된 셀 색상 변경
        public void CellColorChange(DataGridViewCell clickedCell)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.ShowHelp = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                clickedCell.Style.BackColor = colorDialog1.Color;
            }
        }



    }
}
