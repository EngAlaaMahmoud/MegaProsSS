using System.Windows.Forms;

namespace SchoolSystemERp
{
    partial class Events
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EDurationTb = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EDate = new System.Windows.Forms.DateTimePicker();
            this.EDescTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EventDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.schoolDBDataSet1 = new SchoolSystemERP.SchoolDBDataSet1();
            this.eventsTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTblTableAdapter = new SchoolSystemERP.SchoolDBDataSet1TableAdapters.EventsTblTableAdapter();
            this.eIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EDurationTb
            // 
            this.EDurationTb.Location = new System.Drawing.Point(625, 83);
            this.EDurationTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EDurationTb.Name = "EDurationTb";
            this.EDurationTb.Size = new System.Drawing.Size(249, 22);
            this.EDurationTb.TabIndex = 76;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "المناسبات";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(979, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(451, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 32);
            this.label8.TabIndex = 75;
            this.label8.Text = "قائمة المناسبات";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(934, 552);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(94, 36);
            this.BackBtn.TabIndex = 73;
            this.BackBtn.Text = "رجوع";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(642, 150);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(216, 42);
            this.DeleteBtn.TabIndex = 72;
            this.DeleteBtn.Text = "مسح";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(178, 150);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(219, 42);
            this.AddBtn.TabIndex = 71;
            this.AddBtn.Text = "اضافه";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Salmon;
            this.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(405, 150);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(218, 42);
            this.EditBtn.TabIndex = 70;
            this.EditBtn.Text = "تعديل";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(680, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 34);
            this.label6.TabIndex = 69;
            this.label6.Text = "المده";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(414, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 34);
            this.label5.TabIndex = 68;
            this.label5.Text = "التاريخ";
            // 
            // EDate
            // 
            this.EDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EDate.Location = new System.Drawing.Point(385, 83);
            this.EDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EDate.Name = "EDate";
            this.EDate.Size = new System.Drawing.Size(165, 22);
            this.EDate.TabIndex = 67;
            // 
            // EDescTb
            // 
            this.EDescTb.Location = new System.Drawing.Point(54, 85);
            this.EDescTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EDescTb.Name = "EDescTb";
            this.EDescTb.Size = new System.Drawing.Size(270, 22);
            this.EDescTb.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(141, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 34);
            this.label1.TabIndex = 63;
            this.label1.Text = "اسم المناسبه";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 34);
            this.panel1.TabIndex = 62;
            // 
            // EventDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EventDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EventDGV.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EventDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EventDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eIdDataGridViewTextBoxColumn,
            this.eDescDataGridViewTextBoxColumn,
            this.eDateDataGridViewTextBoxColumn,
            this.eDurationDataGridViewTextBoxColumn});
            this.EventDGV.DataSource = this.eventsTblBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EventDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.EventDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EventDGV.Location = new System.Drawing.Point(15, 246);
            this.EventDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EventDGV.Name = "EventDGV";
            this.EventDGV.RowHeadersVisible = false;
            this.EventDGV.RowHeadersWidth = 51;
            this.EventDGV.RowTemplate.Height = 29;
            this.EventDGV.Size = new System.Drawing.Size(1006, 275);
            this.EventDGV.TabIndex = 77;
            this.EventDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EventDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EventDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EventDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EventDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EventDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EventDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EventDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightCyan;
            this.EventDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EventDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.EventDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EventDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EventDGV.ThemeStyle.HeaderStyle.Height = 23;
            this.EventDGV.ThemeStyle.ReadOnly = false;
            this.EventDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EventDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EventDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EventDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EventDGV.ThemeStyle.RowsStyle.Height = 29;
            this.EventDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EventDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EventDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventDGV_CellContentClick);
            // 
            // schoolDBDataSet1
            // 
            this.schoolDBDataSet1.DataSetName = "SchoolDBDataSet1";
            this.schoolDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsTblBindingSource
            // 
            this.eventsTblBindingSource.DataMember = "EventsTbl";
            this.eventsTblBindingSource.DataSource = this.schoolDBDataSet1;
            // 
            // eventsTblTableAdapter
            // 
            this.eventsTblTableAdapter.ClearBeforeFill = true;
            // 
            // eIdDataGridViewTextBoxColumn
            // 
            this.eIdDataGridViewTextBoxColumn.DataPropertyName = "EId";
            this.eIdDataGridViewTextBoxColumn.HeaderText = "المسلسل";
            this.eIdDataGridViewTextBoxColumn.Name = "eIdDataGridViewTextBoxColumn";
            this.eIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eDescDataGridViewTextBoxColumn
            // 
            this.eDescDataGridViewTextBoxColumn.DataPropertyName = "EDesc";
            this.eDescDataGridViewTextBoxColumn.HeaderText = "الوصف";
            this.eDescDataGridViewTextBoxColumn.Name = "eDescDataGridViewTextBoxColumn";
            // 
            // eDateDataGridViewTextBoxColumn
            // 
            this.eDateDataGridViewTextBoxColumn.DataPropertyName = "EDate";
            this.eDateDataGridViewTextBoxColumn.HeaderText = "التاربخ";
            this.eDateDataGridViewTextBoxColumn.Name = "eDateDataGridViewTextBoxColumn";
            // 
            // eDurationDataGridViewTextBoxColumn
            // 
            this.eDurationDataGridViewTextBoxColumn.DataPropertyName = "EDuration";
            this.eDurationDataGridViewTextBoxColumn.HeaderText = "المده";
            this.eDurationDataGridViewTextBoxColumn.Name = "eDurationDataGridViewTextBoxColumn";
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 590);
            this.Controls.Add(this.EventDGV);
            this.Controls.Add(this.EDurationTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EDate);
            this.Controls.Add(this.EDescTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox EDurationTb;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label8;
        private Button BackBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private Button EditBtn;
        private Label label6;
        private Label label5;
        private DateTimePicker EDate;
        private TextBox EDescTb;
        private Label label1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView EventDGV;
        private SchoolSystemERP.SchoolDBDataSet1 schoolDBDataSet1;
        private BindingSource eventsTblBindingSource;
        private SchoolSystemERP.SchoolDBDataSet1TableAdapters.EventsTblTableAdapter eventsTblTableAdapter;
        private DataGridViewTextBoxColumn eIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eDescDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eDurationDataGridViewTextBoxColumn;
    }
}