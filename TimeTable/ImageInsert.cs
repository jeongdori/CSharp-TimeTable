using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.ApplicationModel.VoiceCommands;

namespace TimeTable
{
    internal class ImageInsert
    {
        DataGridView dataGridView1;
        public ImageInsert(DataGridView dataGridView1)
        {
            this.dataGridView1 = dataGridView1;
        }

        //// 이미지 컬럼을 만들고 셀 크기에 맞춰 이미지 삽입
        //DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
        //imgCol.Name = "Image Column";
        //imgCol.HeaderText = "Image Column";
        //dataGridView1.Columns.Add(imgCol);
        //imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        //imgCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        public void LoadImage(DataGridViewCell clickedCell, DataGridViewCellEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.Title = "Select an Image file";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFile.FileName);

                DataGridViewImageCell imageCell = clickedCell as DataGridViewImageCell;

                imageCell.Value = (object)image;
                dataGridView1.Tag = openFile.FileName;

                MemoryStream ms = new MemoryStream(); // 이미지를 저장할 MemoryStream 객체
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // 이미지를 MemoryStream 객체에 저장
                byte[] imgArray = ms.ToArray(); // MemoryStream 객체를 byte 배열로 변환
                
                clickedCell.Value = imgArray;
            }
        }

    }
}
