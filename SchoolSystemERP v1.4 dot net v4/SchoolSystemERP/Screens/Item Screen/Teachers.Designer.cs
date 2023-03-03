using System.Windows.Forms;

namespace SchoolSystemERp
{
    partial class Teachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.TPhoneTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TSubjCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.TGenCb = new System.Windows.Forms.ComboBox();
            this.TAddTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TNameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeachersDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet1 = new SchoolSystemERP.SchoolDBDataSet1();
            this.TSalaryTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.teacherTblTableAdapter = new SchoolSystemERP.SchoolDBDataSet1TableAdapters.TeacherTblTableAdapter();
            this.label17 = new System.Windows.Forms.Label();
            this.searchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(433, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 31);
            this.label8.TabIndex = 45;
            this.label8.Text = "قائمة المدرسين";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(828, 269);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(178, 34);
            this.BackBtn.TabIndex = 43;
            this.BackBtn.Text = "رجوع";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(537, 269);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(199, 34);
            this.DeleteBtn.TabIndex = 42;
            this.DeleteBtn.Text = "حذف";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(12, 269);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(199, 34);
            this.AddBtn.TabIndex = 41;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Salmon;
            this.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(286, 268);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(199, 34);
            this.EditBtn.TabIndex = 40;
            this.EditBtn.Text = "تعديل";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // TPhoneTb
            // 
            this.TPhoneTb.Location = new System.Drawing.Point(858, 103);
            this.TPhoneTb.Name = "TPhoneTb";
            this.TPhoneTb.Size = new System.Drawing.Size(154, 41);
            this.TPhoneTb.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(908, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 34);
            this.label7.TabIndex = 38;
            this.label7.Text = "الهاتف";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(727, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 34);
            this.label6.TabIndex = 37;
            this.label6.Text = "الماده";
            // 
            // TSubjCb
            // 
            this.TSubjCb.FormattingEnabled = true;
            this.TSubjCb.Items.AddRange(new object[] {
            "لغه عربيه",
            "لغه انجليزيه",
            "رياضيات",
            "علوم",
            "رساله",
            "القران الكريم",
            "انشطه",
            "دراسات",
            "دين",
            "نور بيان",
            "اكتشف",
            "تكنولوجيا",
            "تنمية مهارات ",
            "استقبال"});
            this.TSubjCb.Location = new System.Drawing.Point(677, 103);
            this.TSubjCb.Name = "TSubjCb";
            this.TSubjCb.Size = new System.Drawing.Size(151, 41);
            this.TSubjCb.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(25, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 34);
            this.label5.TabIndex = 35;
            this.label5.Text = "تاريخ التعين";
            // 
            // DOB
            // 
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB.Location = new System.Drawing.Point(6, 208);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(199, 41);
            this.DOB.TabIndex = 34;
            // 
            // TGenCb
            // 
            this.TGenCb.FormattingEnabled = true;
            this.TGenCb.Items.AddRange(new object[] {
            "ذكر",
            "انثي"});
            this.TGenCb.Location = new System.Drawing.Point(240, 103);
            this.TGenCb.Name = "TGenCb";
            this.TGenCb.Size = new System.Drawing.Size(172, 41);
            this.TGenCb.TabIndex = 32;
            // 
            // TAddTb
            // 
            this.TAddTb.Location = new System.Drawing.Point(474, 100);
            this.TAddTb.Multiline = true;
            this.TAddTb.Name = "TAddTb";
            this.TAddTb.Size = new System.Drawing.Size(154, 44);
            this.TAddTb.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(513, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 34);
            this.label1.TabIndex = 30;
            this.label1.Text = "العنوان";
            // 
            // TNameTb
            // 
            this.TNameTb.Location = new System.Drawing.Point(25, 103);
            this.TNameTb.Name = "TNameTb";
            this.TNameTb.Size = new System.Drawing.Size(197, 41);
            this.TNameTb.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(38, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 34);
            this.label3.TabIndex = 28;
            this.label3.Text = "الاسم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "المدرسين";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(979, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(299, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 34);
            this.label4.TabIndex = 33;
            this.label4.Text = "النوع";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 42);
            this.panel1.TabIndex = 27;
            // 
            // TeachersDGV
            // 
            this.TeachersDGV.AllowUserToAddRows = false;
            this.TeachersDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TeachersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TeachersDGV.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeachersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TeachersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TeachersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIdDataGridViewTextBoxColumn,
            this.tNameDataGridViewTextBoxColumn,
            this.tGenDataGridViewTextBoxColumn,
            this.tPhoneDataGridViewTextBoxColumn,
            this.tSubjectDataGridViewTextBoxColumn,
            this.tAddDataGridViewTextBoxColumn,
            this.tDOBDataGridViewTextBoxColumn,
            this.tSalaryDataGridViewTextBoxColumn});
            this.TeachersDGV.DataSource = this.teacherTblBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeachersDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.TeachersDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TeachersDGV.Location = new System.Drawing.Point(35, 352);
            this.TeachersDGV.Name = "TeachersDGV";
            this.TeachersDGV.ReadOnly = true;
            this.TeachersDGV.RowHeadersVisible = false;
            this.TeachersDGV.RowHeadersWidth = 51;
            this.TeachersDGV.RowTemplate.Height = 29;
            this.TeachersDGV.Size = new System.Drawing.Size(971, 352);
            this.TeachersDGV.TabIndex = 46;
            this.TeachersDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TeachersDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TeachersDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TeachersDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TeachersDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TeachersDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TeachersDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TeachersDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightCyan;
            this.TeachersDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TeachersDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.TeachersDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TeachersDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TeachersDGV.ThemeStyle.HeaderStyle.Height = 23;
            this.TeachersDGV.ThemeStyle.ReadOnly = true;
            this.TeachersDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TeachersDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TeachersDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TeachersDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TeachersDGV.ThemeStyle.RowsStyle.Height = 29;
            this.TeachersDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TeachersDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TeachersDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeachersDGV_CellContentClick);
            // 
            // tIdDataGridViewTextBoxColumn
            // 
            this.tIdDataGridViewTextBoxColumn.DataPropertyName = "TId";
            this.tIdDataGridViewTextBoxColumn.HeaderText = "المسلسل";
            this.tIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tIdDataGridViewTextBoxColumn.Name = "tIdDataGridViewTextBoxColumn";
            this.tIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tNameDataGridViewTextBoxColumn
            // 
            this.tNameDataGridViewTextBoxColumn.DataPropertyName = "TName";
            this.tNameDataGridViewTextBoxColumn.HeaderText = "الاسم";
            this.tNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tNameDataGridViewTextBoxColumn.Name = "tNameDataGridViewTextBoxColumn";
            this.tNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tGenDataGridViewTextBoxColumn
            // 
            this.tGenDataGridViewTextBoxColumn.DataPropertyName = "TGen";
            this.tGenDataGridViewTextBoxColumn.HeaderText = "الجنس";
            this.tGenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tGenDataGridViewTextBoxColumn.Name = "tGenDataGridViewTextBoxColumn";
            this.tGenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tPhoneDataGridViewTextBoxColumn
            // 
            this.tPhoneDataGridViewTextBoxColumn.DataPropertyName = "TPhone";
            this.tPhoneDataGridViewTextBoxColumn.HeaderText = "موبايل";
            this.tPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tPhoneDataGridViewTextBoxColumn.Name = "tPhoneDataGridViewTextBoxColumn";
            this.tPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tSubjectDataGridViewTextBoxColumn
            // 
            this.tSubjectDataGridViewTextBoxColumn.DataPropertyName = "TSubject";
            this.tSubjectDataGridViewTextBoxColumn.HeaderText = "الماده";
            this.tSubjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tSubjectDataGridViewTextBoxColumn.Name = "tSubjectDataGridViewTextBoxColumn";
            this.tSubjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tAddDataGridViewTextBoxColumn
            // 
            this.tAddDataGridViewTextBoxColumn.DataPropertyName = "TAdd";
            this.tAddDataGridViewTextBoxColumn.HeaderText = "العنوان";
            this.tAddDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tAddDataGridViewTextBoxColumn.Name = "tAddDataGridViewTextBoxColumn";
            this.tAddDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tDOBDataGridViewTextBoxColumn
            // 
            this.tDOBDataGridViewTextBoxColumn.DataPropertyName = "TDOB";
            this.tDOBDataGridViewTextBoxColumn.HeaderText = "تاريخ التعين";
            this.tDOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tDOBDataGridViewTextBoxColumn.Name = "tDOBDataGridViewTextBoxColumn";
            this.tDOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tSalaryDataGridViewTextBoxColumn
            // 
            this.tSalaryDataGridViewTextBoxColumn.DataPropertyName = "TSalary";
            this.tSalaryDataGridViewTextBoxColumn.HeaderText = "الراتب";
            this.tSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tSalaryDataGridViewTextBoxColumn.Name = "tSalaryDataGridViewTextBoxColumn";
            this.tSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teacherTblBindingSource
            // 
            this.teacherTblBindingSource.DataMember = "TeacherTbl";
            this.teacherTblBindingSource.DataSource = this.schoolDBDataSet1;
            // 
            // schoolDBDataSet1
            // 
            this.schoolDBDataSet1.DataSetName = "SchoolDBDataSet1";
            this.schoolDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TSalaryTb
            // 
            this.TSalaryTb.Location = new System.Drawing.Point(240, 205);
            this.TSalaryTb.Multiline = true;
            this.TSalaryTb.Name = "TSalaryTb";
            this.TSalaryTb.Size = new System.Drawing.Size(154, 44);
            this.TSalaryTb.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(285, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 34);
            this.label9.TabIndex = 47;
            this.label9.Text = "الراتب";
            // 
            // teacherTblTableAdapter
            // 
            this.teacherTblTableAdapter.ClearBeforeFill = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label17.ForeColor = System.Drawing.Color.DarkCyan;
            this.label17.Location = new System.Drawing.Point(267, 309);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 34);
            this.label17.TabIndex = 51;
            this.label17.Text = "بحث";
            // 
            // searchtxt
            // 
            this.searchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchtxt.DefaultText = "";
            this.searchtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchtxt.Location = new System.Drawing.Point(12, 310);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.PasswordChar = '\0';
            this.searchtxt.PlaceholderText = "";
            this.searchtxt.SelectedText = "";
            this.searchtxt.Size = new System.Drawing.Size(237, 36);
            this.searchtxt.TabIndex = 50;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 737);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.TSalaryTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TeachersDGV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.TPhoneTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TSubjCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.TGenCb);
            this.Controls.Add(this.TAddTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TNameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private Button BackBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private Button EditBtn;
        private TextBox TPhoneTb;
        private Label label7;
        private Label label6;
        private ComboBox TSubjCb;
        private Label label5;
        private DateTimePicker DOB;
        private ComboBox TGenCb;
        private TextBox TAddTb;
        private Label label1;
        private TextBox TNameTb;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label4;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView TeachersDGV;
        private TextBox TSalaryTb;
        private Label label9;
        private SchoolSystemERP.SchoolDBDataSet1 schoolDBDataSet1;
        private BindingSource teacherTblBindingSource;
        private SchoolSystemERP.SchoolDBDataSet1TableAdapters.TeacherTblTableAdapter teacherTblTableAdapter;
        private Label label17;
        private Guna.UI2.WinForms.Guna2TextBox searchtxt;
        private DataGridViewTextBoxColumn tIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tGenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tSubjectDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tAddDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tDOBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tSalaryDataGridViewTextBoxColumn;
    }
}