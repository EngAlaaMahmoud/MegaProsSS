using System.Windows.Forms;

namespace SchoolSystemERp
{
    partial class AttendenceTecher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendenceTecher));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AttStatusCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AttDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.StIdCb = new System.Windows.Forms.ComboBox();
            this.attendanceTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet1 = new SchoolSystemERP.SchoolDBDataSet1();
            this.StNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AttListDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.attNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attStIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attStNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attndTcherTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet = new SchoolSystemERP.SchoolDBDataSet();
            this.attendanceTblTableAdapter = new SchoolSystemERP.SchoolDBDataSet1TableAdapters.AttendanceTblTableAdapter();
            this.label17 = new System.Windows.Forms.Label();
            this.searchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.schoolDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attndTcherTblTableAdapter = new SchoolSystemERP.SchoolDBDataSetTableAdapters.AttndTcherTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttListDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attndTcherTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(354, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 31);
            this.label8.TabIndex = 45;
            this.label8.Text = "قائمة الحضور";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(710, 238);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(178, 35);
            this.BackBtn.TabIndex = 43;
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
            this.DeleteBtn.Location = new System.Drawing.Point(469, 238);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(199, 35);
            this.DeleteBtn.TabIndex = 42;
            this.DeleteBtn.Text = "تهيئه";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(3, 238);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(199, 35);
            this.AddBtn.TabIndex = 41;
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
            this.EditBtn.Location = new System.Drawing.Point(233, 238);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(199, 35);
            this.EditBtn.TabIndex = 40;
            this.EditBtn.Text = "تعديل";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(752, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 34);
            this.label6.TabIndex = 37;
            this.label6.Text = "الحاله";
            // 
            // AttStatusCb
            // 
            this.AttStatusCb.FormattingEnabled = true;
            this.AttStatusCb.Items.AddRange(new object[] {
            "حاضر",
            "غائب",
            "استاذن"});
            this.AttStatusCb.Location = new System.Drawing.Point(737, 96);
            this.AttStatusCb.Name = "AttStatusCb";
            this.AttStatusCb.Size = new System.Drawing.Size(151, 35);
            this.AttStatusCb.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(503, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 34);
            this.label5.TabIndex = 35;
            this.label5.Text = "التاريخ";
            // 
            // AttDatePicker
            // 
            this.AttDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AttDatePicker.Location = new System.Drawing.Point(503, 96);
            this.AttDatePicker.Name = "AttDatePicker";
            this.AttDatePicker.Size = new System.Drawing.Size(165, 36);
            this.AttDatePicker.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 34);
            this.label4.TabIndex = 33;
            this.label4.Text = "الرقم المسلسل";
            // 
            // StIdCb
            // 
            this.StIdCb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.attendanceTblBindingSource, "AttStId", true));
            this.StIdCb.FormattingEnabled = true;
            this.StIdCb.Location = new System.Drawing.Point(12, 96);
            this.StIdCb.Name = "StIdCb";
            this.StIdCb.Size = new System.Drawing.Size(151, 35);
            this.StIdCb.TabIndex = 32;
            this.StIdCb.SelectionChangeCommitted += new System.EventHandler(this.StIdCb_SelectionChangeCommitted);
            // 
            // attendanceTblBindingSource
            // 
            this.attendanceTblBindingSource.DataMember = "AttendanceTbl";
            this.attendanceTblBindingSource.DataSource = this.schoolDBDataSet1;
            // 
            // schoolDBDataSet1
            // 
            this.schoolDBDataSet1.DataSetName = "SchoolDBDataSet1";
            this.schoolDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StNameTb
            // 
            this.StNameTb.Enabled = false;
            this.StNameTb.Location = new System.Drawing.Point(230, 96);
            this.StNameTb.Name = "StNameTb";
            this.StNameTb.Size = new System.Drawing.Size(202, 36);
            this.StNameTb.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(233, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 34);
            this.label1.TabIndex = 30;
            this.label1.Text = "الاسم";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 42);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "حضور المدرسين";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(867, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AttListDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.AttListDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.AttListDGV.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttListDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.AttListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AttListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attNumDataGridViewTextBoxColumn,
            this.attStIdDataGridViewTextBoxColumn,
            this.attStNameDataGridViewTextBoxColumn,
            this.attDateDataGridViewTextBoxColumn,
            this.attStatusDataGridViewTextBoxColumn});
            this.AttListDGV.DataSource = this.attndTcherTblBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttListDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.AttListDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttListDGV.Location = new System.Drawing.Point(12, 351);
            this.AttListDGV.Name = "AttListDGV";
            this.AttListDGV.RowHeadersVisible = false;
            this.AttListDGV.RowHeadersWidth = 51;
            this.AttListDGV.RowTemplate.Height = 29;
            this.AttListDGV.Size = new System.Drawing.Size(894, 353);
            this.AttListDGV.TabIndex = 46;
            this.AttListDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AttListDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AttListDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AttListDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AttListDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AttListDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AttListDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttListDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightCyan;
            this.AttListDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AttListDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.AttListDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AttListDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AttListDGV.ThemeStyle.HeaderStyle.Height = 23;
            this.AttListDGV.ThemeStyle.ReadOnly = false;
            this.AttListDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AttListDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AttListDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AttListDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AttListDGV.ThemeStyle.RowsStyle.Height = 29;
            this.AttListDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttListDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AttListDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttListDGV_CellContentClick);
            // 
            // attNumDataGridViewTextBoxColumn
            // 
            this.attNumDataGridViewTextBoxColumn.DataPropertyName = "AttNum";
            this.attNumDataGridViewTextBoxColumn.HeaderText = "رقم الغياب";
            this.attNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attNumDataGridViewTextBoxColumn.Name = "attNumDataGridViewTextBoxColumn";
            this.attNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attStIdDataGridViewTextBoxColumn
            // 
            this.attStIdDataGridViewTextBoxColumn.DataPropertyName = "AttStId";
            this.attStIdDataGridViewTextBoxColumn.HeaderText = "المسلسل";
            this.attStIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attStIdDataGridViewTextBoxColumn.Name = "attStIdDataGridViewTextBoxColumn";
            // 
            // attStNameDataGridViewTextBoxColumn
            // 
            this.attStNameDataGridViewTextBoxColumn.DataPropertyName = "AttStName";
            this.attStNameDataGridViewTextBoxColumn.HeaderText = "الاسم";
            this.attStNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attStNameDataGridViewTextBoxColumn.Name = "attStNameDataGridViewTextBoxColumn";
            // 
            // attDateDataGridViewTextBoxColumn
            // 
            this.attDateDataGridViewTextBoxColumn.DataPropertyName = "AttDate";
            this.attDateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.attDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attDateDataGridViewTextBoxColumn.Name = "attDateDataGridViewTextBoxColumn";
            // 
            // attStatusDataGridViewTextBoxColumn
            // 
            this.attStatusDataGridViewTextBoxColumn.DataPropertyName = "AttStatus";
            this.attStatusDataGridViewTextBoxColumn.HeaderText = "الحاله";
            this.attStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attStatusDataGridViewTextBoxColumn.Name = "attStatusDataGridViewTextBoxColumn";
            // 
            // attndTcherTblBindingSource
            // 
            this.attndTcherTblBindingSource.DataMember = "AttndTcherTbl";
            this.attndTcherTblBindingSource.DataSource = this.schoolDBDataSet;
            // 
            // schoolDBDataSet
            // 
            this.schoolDBDataSet.DataSetName = "SchoolDBDataSet";
            this.schoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceTblTableAdapter
            // 
            this.attendanceTblTableAdapter.ClearBeforeFill = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label17.ForeColor = System.Drawing.Color.DarkCyan;
            this.label17.Location = new System.Drawing.Point(256, 292);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 34);
            this.label17.TabIndex = 76;
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
            this.searchtxt.Location = new System.Drawing.Point(3, 292);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.PasswordChar = '\0';
            this.searchtxt.PlaceholderText = "اسم الموظف";
            this.searchtxt.SelectedText = "";
            this.searchtxt.Size = new System.Drawing.Size(237, 53);
            this.searchtxt.TabIndex = 75;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // schoolDBDataSet1BindingSource
            // 
            this.schoolDBDataSet1BindingSource.DataSource = this.schoolDBDataSet1;
            this.schoolDBDataSet1BindingSource.Position = 0;
            // 
            // attndTcherTblTableAdapter
            // 
            this.attndTcherTblTableAdapter.ClearBeforeFill = true;
            // 
            // AttendenceTecher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 716);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.AttListDGV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AttStatusCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AttDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StIdCb);
            this.Controls.Add(this.StNameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AttendenceTecher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendence";
            this.Load += new System.EventHandler(this.Attendence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttListDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attndTcherTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private Button BackBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private Button EditBtn;
        private Label label6;
        private ComboBox AttStatusCb;
        private Label label5;
        private DateTimePicker AttDatePicker;
        private Label label4;
        private ComboBox StIdCb;
        private TextBox StNameTb;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2DataGridView AttListDGV;
        private SchoolSystemERP.SchoolDBDataSet1 schoolDBDataSet1;
        private BindingSource attendanceTblBindingSource;
        private SchoolSystemERP.SchoolDBDataSet1TableAdapters.AttendanceTblTableAdapter attendanceTblTableAdapter;
        private Label label17;
        private Guna.UI2.WinForms.Guna2TextBox searchtxt;
        private BindingSource schoolDBDataSet1BindingSource;
        private SchoolSystemERP.SchoolDBDataSet schoolDBDataSet;
        private BindingSource attndTcherTblBindingSource;
        private SchoolSystemERP.SchoolDBDataSetTableAdapters.AttndTcherTblTableAdapter attndTcherTblTableAdapter;
        private DataGridViewTextBoxColumn attNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn attStIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn attStNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn attDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn attStatusDataGridViewTextBoxColumn;
    }
}