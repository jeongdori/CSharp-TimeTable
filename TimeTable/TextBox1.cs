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
    public partial class TextBox1 : TextBox
    {
        public TextBox1()
        {
            InitializeComponent();

            this.Multiline = true;
            this.Text = "";

        }
    }
}
