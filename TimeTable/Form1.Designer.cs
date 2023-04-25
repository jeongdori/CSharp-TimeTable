using System.Windows.Forms;

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
            ExcelImportButton = new Button();
            ExcelViewButton = new Button();
            ExportToExcelButton = new Button();
            PrintButton = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ExcelImportButton);
            panel1.Controls.Add(ExcelViewButton);
            panel1.Controls.Add(ExportToExcelButton);
            panel1.Controls.Add(PrintButton);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 633);
            panel1.TabIndex = 1;
            // 
            // ExcelImportButton
            // 
            ExcelImportButton.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExcelImportButton.Location = new Point(25, 566);
            ExcelImportButton.Name = "ExcelImportButton";
            ExcelImportButton.Size = new Size(120, 43);
            ExcelImportButton.TabIndex = 3;
            ExcelImportButton.Text = "불러오기";
            ExcelImportButton.UseVisualStyleBackColor = true;
            ExcelImportButton.Click += ExcelImport_Click;
            // 
            // ExcelViewButton
            // 
            ExcelViewButton.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExcelViewButton.Location = new Point(151, 566);
            ExcelViewButton.Name = "ExcelViewButton";
            ExcelViewButton.Size = new Size(120, 43);
            ExcelViewButton.TabIndex = 2;
            ExcelViewButton.Text = "엑셀 보기";
            ExcelViewButton.UseVisualStyleBackColor = true;
            ExcelViewButton.Click += ExcelView_Click;
            // 
            // ExportToExcelButton
            // 
            ExportToExcelButton.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExportToExcelButton.Location = new Point(286, 566);
            ExportToExcelButton.Name = "ExportToExcelButton";
            ExportToExcelButton.Size = new Size(120, 43);
            ExportToExcelButton.TabIndex = 2;
            ExportToExcelButton.Text = "엑셀저장";
            ExportToExcelButton.UseVisualStyleBackColor = true;
            ExportToExcelButton.Click += ExcelButtonClick;
            // 
            // PrintButton
            // 
            PrintButton.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PrintButton.Location = new Point(412, 566);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(120, 43);
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(556, 633);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += CellDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(556, 633);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form_Load;
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
    }
}