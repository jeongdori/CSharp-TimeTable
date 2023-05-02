using MySqlX.XDevAPI.Relational;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace TimeTable
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            DBname = new TextBox1();
            DBpw = new TextBox1();
            DBid = new TextBox1();
            comboBox11 = new ComboBox1();
            BackColorChange = new Button();
            DBConn = new Button();
            ExcelSave = new Button();
            ExcelImportButton = new Button();
            ExcelViewButton = new Button();
            ExportToExcelButton = new Button();
            PrintButton = new Button();
            dataGridView1 = new DataGridView();
            imgCol = new DataGridViewImageColumn();
            DBaddress = new TextBox1();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(DBaddress);
            panel1.Controls.Add(DBname);
            panel1.Controls.Add(DBpw);
            panel1.Controls.Add(DBid);
            panel1.Controls.Add(comboBox11);
            panel1.Controls.Add(BackColorChange);
            panel1.Controls.Add(DBConn);
            panel1.Controls.Add(ExcelSave);
            panel1.Controls.Add(ExcelImportButton);
            panel1.Controls.Add(ExcelViewButton);
            panel1.Controls.Add(ExportToExcelButton);
            panel1.Controls.Add(PrintButton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(586, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(129, 844);
            panel1.TabIndex = 1;
            // 
            // DBname
            // 
            DBname.Location = new Point(14, 653);
            DBname.Multiline = true;
            DBname.Name = "DBname";
            DBname.Size = new Size(104, 34);
            DBname.TabIndex = 8;
            DBname.Text = "DB명";
            // 
            // DBpw
            // 
            DBpw.Location = new Point(15, 733);
            DBpw.Multiline = true;
            DBpw.Name = "DBpw";
            DBpw.PasswordChar = '*';
            DBpw.Size = new Size(104, 34);
            DBpw.TabIndex = 7;
            DBpw.Text = "PW";
            // 
            // DBid
            // 
            DBid.Location = new Point(15, 693);
            DBid.Multiline = true;
            DBid.Name = "DBid";
            DBid.Size = new Size(104, 34);
            DBid.TabIndex = 2;
            DBid.Text = "ID";
            // 
            // comboBox11
            // 
            comboBox11.FormattingEnabled = true;
            comboBox11.Items.AddRange(new object[] { "엑셀", "DB", "엑셀", "DB", "엑셀", "DB" });
            comboBox11.Location = new Point(15, 569);
            comboBox11.Name = "comboBox11";
            comboBox11.Size = new Size(103, 28);
            comboBox11.TabIndex = 6;
            // 
            // BackColorChange
            // 
            BackColorChange.Location = new Point(13, 505);
            BackColorChange.Margin = new Padding(4);
            BackColorChange.Name = "BackColorChange";
            BackColorChange.Size = new Size(103, 57);
            BackColorChange.TabIndex = 5;
            BackColorChange.Text = "배경색";
            BackColorChange.UseVisualStyleBackColor = true;
            BackColorChange.Click += BackColorChangeClick;
            // 
            // DBConn
            // 
            DBConn.Font = new Font("맑은 고딕", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            DBConn.Location = new Point(15, 774);
            DBConn.Margin = new Padding(4);
            DBConn.Name = "DBConn";
            DBConn.Size = new Size(103, 57);
            DBConn.TabIndex = 2;
            DBConn.Text = "DB연결";
            DBConn.UseVisualStyleBackColor = true;
            DBConn.Click += DBConnClick;
            // 
            // ExcelSave
            // 
            ExcelSave.Font = new Font("맑은 고딕", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExcelSave.Location = new Point(13, 117);
            ExcelSave.Margin = new Padding(4);
            ExcelSave.Name = "ExcelSave";
            ExcelSave.Size = new Size(103, 57);
            ExcelSave.TabIndex = 4;
            ExcelSave.Text = "저장";
            ExcelSave.UseVisualStyleBackColor = true;
            ExcelSave.Click += ExcelSaveButtonClick;
            // 
            // ExcelImportButton
            // 
            ExcelImportButton.Font = new Font("맑은 고딕", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExcelImportButton.Location = new Point(13, 29);
            ExcelImportButton.Margin = new Padding(4);
            ExcelImportButton.Name = "ExcelImportButton";
            ExcelImportButton.Size = new Size(103, 57);
            ExcelImportButton.TabIndex = 3;
            ExcelImportButton.Text = "불러오기";
            ExcelImportButton.UseVisualStyleBackColor = true;
            ExcelImportButton.Click += ExcelImport_Click;
            // 
            // ExcelViewButton
            // 
            ExcelViewButton.Font = new Font("맑은 고딕", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExcelViewButton.Location = new Point(13, 311);
            ExcelViewButton.Margin = new Padding(4);
            ExcelViewButton.Name = "ExcelViewButton";
            ExcelViewButton.Size = new Size(103, 57);
            ExcelViewButton.TabIndex = 2;
            ExcelViewButton.Text = "엑셀 보기";
            ExcelViewButton.UseVisualStyleBackColor = true;
            ExcelViewButton.Click += ExcelView_Click;
            // 
            // ExportToExcelButton
            // 
            ExportToExcelButton.Font = new Font("맑은 고딕", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExportToExcelButton.Location = new Point(13, 213);
            ExportToExcelButton.Margin = new Padding(4);
            ExportToExcelButton.Name = "ExportToExcelButton";
            ExportToExcelButton.Size = new Size(103, 57);
            ExportToExcelButton.TabIndex = 2;
            ExportToExcelButton.Text = "새로저장";
            ExportToExcelButton.UseVisualStyleBackColor = true;
            ExportToExcelButton.Click += ExcelSaveAsButtonClick;
            // 
            // PrintButton
            // 
            PrintButton.Font = new Font("맑은 고딕", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            PrintButton.Location = new Point(13, 408);
            PrintButton.Margin = new Padding(4);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(103, 57);
            PrintButton.TabIndex = 1;
            PrintButton.Text = "인쇄";
            PrintButton.UseVisualStyleBackColor = true;
            PrintButton.Click += PrintButtonClick;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { imgCol });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(586, 844);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += CellDoubleClick;
            // 
            // imgCol
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            imgCol.DefaultCellStyle = dataGridViewCellStyle2;
            imgCol.HeaderText = "Image Column";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            imgCol.MinimumWidth = 6;
            imgCol.Name = "imgCol";
            // 
            // DBaddress
            // 
            DBaddress.Location = new Point(14, 613);
            DBaddress.Multiline = true;
            DBaddress.Name = "DBaddress";
            DBaddress.Size = new Size(104, 34);
            DBaddress.TabIndex = 9;
            DBaddress.Text = "주소";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(715, 844);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button PrintButton;
        private Button ExportToExcelButton;
        private Button ExcelViewButton;
        private Button ExcelImportButton;
        private Button ExcelSave;
        private Button DBConn;
        private DataGridViewImageColumn imgCol;
        private Button BackColorChange;
        private ComboBox1 comboBox11;
        private TextBox1 DBpw;
        private TextBox1 DBname;
        private TextBox1 DBid;
        private TextBox1 DBaddress;
    }
}