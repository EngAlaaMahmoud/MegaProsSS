namespace SchoolSystemERP
{
    partial class OutGo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutGo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.schoolDBDataSet1 = new SchoolSystemERP.SchoolDBDataSet1();
            this.outGoTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outGoTblTableAdapter = new SchoolSystemERP.SchoolDBDataSet1TableAdapters.OutGoTblTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.NotesTb = new System.Windows.Forms.TextBox();
            this.CostTb = new System.Windows.Forms.TextBox();
            this.DecTb = new System.Windows.Forms.TextBox();
            this.datepicker1 = new System.Windows.Forms.DateTimePicker();
            this.PrintBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.schoolDBDataSet11 = new SchoolSystemERP.SchoolDBDataSet1();
            this.dgvcost = new Guna.UI2.WinForms.Guna2DataGridView();
            this.outGoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outGoNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outGoDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outGoDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outGoCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outGoNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outGoTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.searchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outGoTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outGoTblBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 37);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(714, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(247, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "شاشة التكاليف";
            // 
            // schoolDBDataSet1
            // 
            this.schoolDBDataSet1.DataSetName = "SchoolDBDataSet1";
            this.schoolDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // outGoTblBindingSource
            // 
            this.outGoTblBindingSource.DataMember = "OutGoTbl";
            this.outGoTblBindingSource.DataSource = this.schoolDBDataSet1;
            // 
            // outGoTblTableAdapter
            // 
            this.outGoTblTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(49, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "الاسم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(49, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "الوصف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(49, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "التاربخ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(48, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "المصاريف";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(49, 430);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "ملاحظات";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(132, 80);
            this.NameTb.Margin = new System.Windows.Forms.Padding(4);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(270, 32);
            this.NameTb.TabIndex = 10;
            // 
            // NotesTb
            // 
            this.NotesTb.Location = new System.Drawing.Point(132, 428);
            this.NotesTb.Margin = new System.Windows.Forms.Padding(4);
            this.NotesTb.Multiline = true;
            this.NotesTb.Name = "NotesTb";
            this.NotesTb.Size = new System.Drawing.Size(270, 66);
            this.NotesTb.TabIndex = 11;
            // 
            // CostTb
            // 
            this.CostTb.Location = new System.Drawing.Point(132, 351);
            this.CostTb.Margin = new System.Windows.Forms.Padding(4);
            this.CostTb.Name = "CostTb";
            this.CostTb.Size = new System.Drawing.Size(270, 32);
            this.CostTb.TabIndex = 12;
            // 
            // DecTb
            // 
            this.DecTb.Location = new System.Drawing.Point(132, 198);
            this.DecTb.Margin = new System.Windows.Forms.Padding(4);
            this.DecTb.Multiline = true;
            this.DecTb.Name = "DecTb";
            this.DecTb.Size = new System.Drawing.Size(354, 145);
            this.DecTb.TabIndex = 13;
            // 
            // datepicker1
            // 
            this.datepicker1.Location = new System.Drawing.Point(132, 158);
            this.datepicker1.Margin = new System.Windows.Forms.Padding(4);
            this.datepicker1.Name = "datepicker1";
            this.datepicker1.Size = new System.Drawing.Size(270, 32);
            this.datepicker1.TabIndex = 14;
            // 
            // PrintBtn
            // 
            this.PrintBtn.BorderRadius = 2;
            this.PrintBtn.BorderThickness = 1;
            this.PrintBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PrintBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PrintBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PrintBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PrintBtn.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.PrintBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PrintBtn.ForeColor = System.Drawing.Color.White;
            this.PrintBtn.Location = new System.Drawing.Point(493, 346);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(191, 45);
            this.PrintBtn.TabIndex = 71;
            this.PrintBtn.Text = "طباعه";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(493, 444);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(191, 45);
            this.guna2Button2.TabIndex = 72;
            this.guna2Button2.Text = "رجوع";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(493, 243);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(199, 48);
            this.DeleteBtn.TabIndex = 75;
            this.DeleteBtn.Text = "حذف";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(493, 64);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(199, 48);
            this.SaveBtn.TabIndex = 74;
            this.SaveBtn.Text = "اضافه";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.BackColor = System.Drawing.Color.Salmon;
            this.Editbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Editbtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Editbtn.ForeColor = System.Drawing.Color.White;
            this.Editbtn.Location = new System.Drawing.Point(493, 142);
            this.Editbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(199, 48);
            this.Editbtn.TabIndex = 73;
            this.Editbtn.Text = "تعديل";
            this.Editbtn.UseVisualStyleBackColor = false;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // schoolDBDataSet11
            // 
            this.schoolDBDataSet11.DataSetName = "SchoolDBDataSet1";
            this.schoolDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvcost
            // 
            this.dgvcost.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvcost.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcost.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcost.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvcost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.outGoIdDataGridViewTextBoxColumn,
            this.outGoNameDataGridViewTextBoxColumn,
            this.outGoDateDataGridViewTextBoxColumn,
            this.outGoDescDataGridViewTextBoxColumn,
            this.outGoCostDataGridViewTextBoxColumn,
            this.outGoNoteDataGridViewTextBoxColumn});
            this.dgvcost.DataSource = this.outGoTblBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcost.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcost.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvcost.Location = new System.Drawing.Point(25, 548);
            this.dgvcost.Name = "dgvcost";
            this.dgvcost.RowHeadersVisible = false;
            this.dgvcost.RowHeadersWidth = 51;
            this.dgvcost.RowTemplate.Height = 29;
            this.dgvcost.Size = new System.Drawing.Size(689, 260);
            this.dgvcost.TabIndex = 76;
            this.dgvcost.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvcost.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvcost.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvcost.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvcost.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvcost.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvcost.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvcost.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightCyan;
            this.dgvcost.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvcost.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.dgvcost.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvcost.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvcost.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvcost.ThemeStyle.ReadOnly = false;
            this.dgvcost.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvcost.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvcost.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvcost.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvcost.ThemeStyle.RowsStyle.Height = 29;
            this.dgvcost.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvcost.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvcost.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcost_CellContentClick);
            // 
            // outGoIdDataGridViewTextBoxColumn
            // 
            this.outGoIdDataGridViewTextBoxColumn.DataPropertyName = "OutGoId";
            this.outGoIdDataGridViewTextBoxColumn.HeaderText = "المسلسل";
            this.outGoIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.outGoIdDataGridViewTextBoxColumn.Name = "outGoIdDataGridViewTextBoxColumn";
            // 
            // outGoNameDataGridViewTextBoxColumn
            // 
            this.outGoNameDataGridViewTextBoxColumn.DataPropertyName = "OutGoName";
            this.outGoNameDataGridViewTextBoxColumn.HeaderText = "الاسم";
            this.outGoNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.outGoNameDataGridViewTextBoxColumn.Name = "outGoNameDataGridViewTextBoxColumn";
            // 
            // outGoDateDataGridViewTextBoxColumn
            // 
            this.outGoDateDataGridViewTextBoxColumn.DataPropertyName = "OutGoDate";
            this.outGoDateDataGridViewTextBoxColumn.HeaderText = "التاربخ";
            this.outGoDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.outGoDateDataGridViewTextBoxColumn.Name = "outGoDateDataGridViewTextBoxColumn";
            // 
            // outGoDescDataGridViewTextBoxColumn
            // 
            this.outGoDescDataGridViewTextBoxColumn.DataPropertyName = "OutGoDesc";
            this.outGoDescDataGridViewTextBoxColumn.HeaderText = "الوصف";
            this.outGoDescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.outGoDescDataGridViewTextBoxColumn.Name = "outGoDescDataGridViewTextBoxColumn";
            // 
            // outGoCostDataGridViewTextBoxColumn
            // 
            this.outGoCostDataGridViewTextBoxColumn.DataPropertyName = "OutGoCost";
            this.outGoCostDataGridViewTextBoxColumn.HeaderText = "التكاليف";
            this.outGoCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.outGoCostDataGridViewTextBoxColumn.Name = "outGoCostDataGridViewTextBoxColumn";
            // 
            // outGoNoteDataGridViewTextBoxColumn
            // 
            this.outGoNoteDataGridViewTextBoxColumn.DataPropertyName = "OutGoNote";
            this.outGoNoteDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.outGoNoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.outGoNoteDataGridViewTextBoxColumn.Name = "outGoNoteDataGridViewTextBoxColumn";
            // 
            // outGoTblBindingSource1
            // 
            this.outGoTblBindingSource1.DataMember = "OutGoTbl";
            this.outGoTblBindingSource1.DataSource = this.schoolDBDataSet1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label17.ForeColor = System.Drawing.Color.DarkCyan;
            this.label17.Location = new System.Drawing.Point(398, 506);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 34);
            this.label17.TabIndex = 78;
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
            this.searchtxt.Location = new System.Drawing.Point(145, 506);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.PasswordChar = '\0';
            this.searchtxt.PlaceholderText = "";
            this.searchtxt.SelectedText = "";
            this.searchtxt.Size = new System.Drawing.Size(237, 36);
            this.searchtxt.TabIndex = 77;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // OutGo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 835);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.dgvcost);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.datepicker1);
            this.Controls.Add(this.DecTb);
            this.Controls.Add(this.CostTb);
            this.Controls.Add(this.NotesTb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OutGo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OutGo";
            this.Load += new System.EventHandler(this.OutGo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outGoTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outGoTblBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private SchoolDBDataSet1 schoolDBDataSet1;
        private System.Windows.Forms.BindingSource outGoTblBindingSource;
        private SchoolDBDataSet1TableAdapters.OutGoTblTableAdapter outGoTblTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.TextBox NotesTb;
        private System.Windows.Forms.TextBox CostTb;
        private System.Windows.Forms.TextBox DecTb;
        private System.Windows.Forms.DateTimePicker datepicker1;
        private Guna.UI2.WinForms.Guna2Button PrintBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button Editbtn;
       
        private SchoolDBDataSet1 schoolDBDataSet11;
        private Guna.UI2.WinForms.Guna2DataGridView dgvcost;
        private System.Windows.Forms.BindingSource outGoTblBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn outGoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outGoNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outGoDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outGoDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outGoCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outGoNoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox searchtxt;
    }
}