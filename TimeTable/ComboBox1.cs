using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable
{
    public partial class ComboBox1 : ComboBox
    {
        public ComboBox1()
        {
            InitializeComponent();
            string[] data = { "엑셀", "DB"};

            this.Items.AddRange(data);
            this.SelectedIndex = 0;
        }


        //사용자설정 속성 생성해보기
        [Category("CostomProperty"), Description("사용자 설정 속성")]
        private string myCustomProperty;

        public string MyCustomProperty
        {
            get { return myCustomProperty; }
            set
            {
                myCustomProperty = value;
                // 속성 값이 변경되면 실행할 코드 작성
            }
        }



    }
}
