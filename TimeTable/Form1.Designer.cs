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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            BackColorChange = new Button();
            DBConn = new Button();
            ExcelSave = new Button();
            ExcelImportButton = new Button();
            ExcelViewButton = new Button();
            ExportToExcelButton = new Button();
            PrintButton = new Button();
            dataGridView1 = new DataGridView();
            imgCol = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BackColorChange);
            panel1.Controls.Add(DBConn);
            panel1.Controls.Add(ExcelSave);
            panel1.Controls.Add(ExcelImportButton);
            panel1.Controls.Add(ExcelViewButton);
            panel1.Controls.Add(ExportToExcelButton);
            panel1.Controls.Add(PrintButton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(456, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 633);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(10, 214);
            button1.Name = "button1";
            button1.Size = new Size(78, 26);
            button1.TabIndex = 10;
            button1.Text = "토요일";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SaturdayViewClick;
            // 
            // BackColorChange
            // 
            BackColorChange.Font = new Font("맑은 고딕", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            BackColorChange.Location = new Point(10, 182);
            BackColorChange.Name = "BackColorChange";
            BackColorChange.Size = new Size(78, 26);
            BackColorChange.TabIndex = 5;
            BackColorChange.Text = "배경색";
            BackColorChange.UseVisualStyleBackColor = true;
            BackColorChange.Click += BackColorChangeClick;
            // 
            // DBConn
            // 
            DBConn.Font = new Font("맑은 고딕", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            DBConn.Location = new Point(12, 580);
            DBConn.Name = "DBConn";
            DBConn.Size = new Size(78, 26);
            DBConn.TabIndex = 2;
            DBConn.Text = "DB연결";
            DBConn.UseVisualStyleBackColor = true;
            DBConn.Click += DBConnClick;
            // 
            // ExcelSave
            // 
            ExcelSave.Font = new Font("맑은 고딕", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExcelSave.Location = new Point(10, 54);
            ExcelSave.Name = "ExcelSave";
            ExcelSave.Size = new Size(78, 26);
            ExcelSave.TabIndex = 4;
            ExcelSave.Text = "저장";
            ExcelSave.UseVisualStyleBackColor = true;
            ExcelSave.Click += ExcelSaveButtonClick;
            // 
            // ExcelImportButton
            // 
            ExcelImportButton.Font = new Font("맑은 고딕", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExcelImportButton.Location = new Point(10, 22);
            ExcelImportButton.Name = "ExcelImportButton";
            ExcelImportButton.Size = new Size(78, 26);
            ExcelImportButton.TabIndex = 3;
            ExcelImportButton.Text = "불러오기";
            ExcelImportButton.UseVisualStyleBackColor = true;
            ExcelImportButton.Click += ExcelImport_Click;
            // 
            // ExcelViewButton
            // 
            ExcelViewButton.Font = new Font("맑은 고딕", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExcelViewButton.Location = new Point(10, 118);
            ExcelViewButton.Name = "ExcelViewButton";
            ExcelViewButton.Size = new Size(78, 26);
            ExcelViewButton.TabIndex = 2;
            ExcelViewButton.Text = "엑셀 보기";
            ExcelViewButton.UseVisualStyleBackColor = true;
            ExcelViewButton.Click += ExcelView_Click;
            // 
            // ExportToExcelButton
            // 
            ExportToExcelButton.Font = new Font("맑은 고딕", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExportToExcelButton.Location = new Point(10, 86);
            ExportToExcelButton.Name = "ExportToExcelButton";
            ExportToExcelButton.Size = new Size(78, 26);
            ExportToExcelButton.TabIndex = 2;
            ExportToExcelButton.Text = "새로저장";
            ExportToExcelButton.UseVisualStyleBackColor = true;
            ExportToExcelButton.Click += ExcelSaveAsButtonClick;
            // 
            // PrintButton
            // 
            PrintButton.Font = new Font("맑은 고딕", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            PrintButton.Location = new Point(10, 150);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(78, 26);
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
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(456, 633);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += CellDoubleClick;
            // 
            // imgCol
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            imgCol.DefaultCellStyle = dataGridViewCellStyle1;
            imgCol.HeaderText = "Image Column";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            imgCol.MinimumWidth = 6;
            imgCol.Name = "imgCol";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(556, 633);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
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
        private Button button1;
    }
}