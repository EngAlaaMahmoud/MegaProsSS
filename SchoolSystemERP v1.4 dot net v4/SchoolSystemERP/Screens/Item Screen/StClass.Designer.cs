namespace SchoolSystemERP
{
    partial class StClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StClass));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.StageDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.stIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stGenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet1 = new SchoolSystemERP.SchoolDBDataSet1();
            this.studentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stageTb = new System.Windows.Forms.TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.schoolDBDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTblTableAdapter = new SchoolSystemERP.SchoolDBDataSet1TableAdapters.StudentTblTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.ClassCb = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StageDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Name = "label1";
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
            resources.ApplyResources(this.PrintBtn, "PrintBtn");
            this.PrintBtn.ForeColor = System.Drawing.Color.White;
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.guna2Button2, "guna2Button2");
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // StageDgv
            // 
            this.StageDgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.StageDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StageDgv.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StageDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.StageDgv, "StageDgv");
            this.StageDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StageDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stIdDataGridViewTextBoxColumn,
            this.stNameDataGridViewTextBoxColumn,
            this.stGenDataGridViewTextBoxColumn,
            this.stDOBDataGridViewTextBoxColumn,
            this.stClassDataGridViewTextBoxColumn,
            this.stMobileDataGridViewTextBoxColumn,
            this.stAddDataGridViewTextBoxColumn});
            this.StageDgv.DataSource = this.studentTblBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StageDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.StageDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StageDgv.Name = "StageDgv";
            this.StageDgv.RowHeadersVisible = false;
            this.StageDgv.RowTemplate.Height = 24;
            this.StageDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StageDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StageDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StageDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StageDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StageDgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StageDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StageDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StageDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StageDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.StageDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StageDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StageDgv.ThemeStyle.HeaderStyle.Height = 4;
            this.StageDgv.ThemeStyle.ReadOnly = false;
            this.StageDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StageDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StageDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.StageDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StageDgv.ThemeStyle.RowsStyle.Height = 24;
            this.StageDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StageDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // stIdDataGridViewTextBoxColumn
            // 
            this.stIdDataGridViewTextBoxColumn.DataPropertyName = "StId";
            resources.ApplyResources(this.stIdDataGridViewTextBoxColumn, "stIdDataGridViewTextBoxColumn");
            this.stIdDataGridViewTextBoxColumn.Name = "stIdDataGridViewTextBoxColumn";
            this.stIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stNameDataGridViewTextBoxColumn
            // 
            this.stNameDataGridViewTextBoxColumn.DataPropertyName = "StName";
            resources.ApplyResources(this.stNameDataGridViewTextBoxColumn, "stNameDataGridViewTextBoxColumn");
            this.stNameDataGridViewTextBoxColumn.Name = "stNameDataGridViewTextBoxColumn";
            // 
            // stGenDataGridViewTextBoxColumn
            // 
            this.stGenDataGridViewTextBoxColumn.DataPropertyName = "StGen";
            resources.ApplyResources(this.stGenDataGridViewTextBoxColumn, "stGenDataGridViewTextBoxColumn");
            this.stGenDataGridViewTextBoxColumn.Name = "stGenDataGridViewTextBoxColumn";
            // 
            // stDOBDataGridViewTextBoxColumn
            // 
            this.stDOBDataGridViewTextBoxColumn.DataPropertyName = "StDOB";
            resources.ApplyResources(this.stDOBDataGridViewTextBoxColumn, "stDOBDataGridViewTextBoxColumn");
            this.stDOBDataGridViewTextBoxColumn.Name = "stDOBDataGridViewTextBoxColumn";
            // 
            // stClassDataGridViewTextBoxColumn
            // 
            this.stClassDataGridViewTextBoxColumn.DataPropertyName = "StClass";
            resources.ApplyResources(this.stClassDataGridViewTextBoxColumn, "stClassDataGridViewTextBoxColumn");
            this.stClassDataGridViewTextBoxColumn.Name = "stClassDataGridViewTextBoxColumn";
            // 
            // stMobileDataGridViewTextBoxColumn
            // 
            this.stMobileDataGridViewTextBoxColumn.DataPropertyName = "StMobile";
            resources.ApplyResources(this.stMobileDataGridViewTextBoxColumn, "stMobileDataGridViewTextBoxColumn");
            this.stMobileDataGridViewTextBoxColumn.Name = "stMobileDataGridViewTextBoxColumn";
            // 
            // stAddDataGridViewTextBoxColumn
            // 
            this.stAddDataGridViewTextBoxColumn.DataPropertyName = "StAdd";
            resources.ApplyResources(this.stAddDataGridViewTextBoxColumn, "stAddDataGridViewTextBoxColumn");
            this.stAddDataGridViewTextBoxColumn.Name = "stAddDataGridViewTextBoxColumn";
            // 
            // studentTblBindingSource1
            // 
            this.studentTblBindingSource1.DataMember = "StudentTbl";
            this.studentTblBindingSource1.DataSource = this.schoolDBDataSet1BindingSource;
            // 
            // schoolDBDataSet1BindingSource
            // 
            this.schoolDBDataSet1BindingSource.DataSource = this.schoolDBDataSet1;
            this.schoolDBDataSet1BindingSource.Position = 0;
            // 
            // schoolDBDataSet1
            // 
            this.schoolDBDataSet1.DataSetName = "SchoolDBDataSet1";
            this.schoolDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTblBindingSource
            // 
            this.studentTblBindingSource.DataMember = "StudentTbl";
            this.studentTblBindingSource.DataSource = this.schoolDBDataSet1BindingSource;
            // 
            // stageTb
            // 
            resources.ApplyResources(this.stageTb, "stageTb");
            this.stageTb.Name = "stageTb";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.guna2Button1, "guna2Button1");
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // schoolDBDataSet1BindingSource1
            // 
            this.schoolDBDataSet1BindingSource1.DataSource = this.schoolDBDataSet1;
            this.schoolDBDataSet1BindingSource1.Position = 0;
            // 
            // studentTblTableAdapter
            // 
            this.studentTblTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Name = "label6";
            // 
            // ClassCb
            // 
            this.ClassCb.FormattingEnabled = true;
            this.ClassCb.Items.AddRange(new object[] {
            resources.GetString("ClassCb.Items"),
            resources.GetString("ClassCb.Items1"),
            resources.GetString("ClassCb.Items2"),
            resources.GetString("ClassCb.Items3"),
            resources.GetString("ClassCb.Items4"),
            resources.GetString("ClassCb.Items5"),
            resources.GetString("ClassCb.Items6"),
            resources.GetString("ClassCb.Items7"),
            resources.GetString("ClassCb.Items8"),
            resources.GetString("ClassCb.Items9"),
            resources.GetString("ClassCb.Items10"),
            resources.GetString("ClassCb.Items11"),
            resources.GetString("ClassCb.Items12"),
            resources.GetString("ClassCb.Items13"),
            resources.GetString("ClassCb.Items14"),
            resources.GetString("ClassCb.Items15"),
            resources.GetString("ClassCb.Items16"),
            resources.GetString("ClassCb.Items17"),
            resources.GetString("ClassCb.Items18")});
            resources.ApplyResources(this.ClassCb, "ClassCb");
            this.ClassCb.Name = "ClassCb";
            // 
            // StClass
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClassCb);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.stageTb);
            this.Controls.Add(this.StageDgv);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StClass";
            this.Load += new System.EventHandler(this.StClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StageDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button PrintBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2DataGridView StageDgv;
        private System.Windows.Forms.TextBox stageTb;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.BindingSource schoolDBDataSet1BindingSource1;
        private SchoolDBDataSet1 schoolDBDataSet1;
        private System.Windows.Forms.BindingSource schoolDBDataSet1BindingSource;
        private System.Windows.Forms.BindingSource studentTblBindingSource;
        private SchoolDBDataSet1TableAdapters.StudentTblTableAdapter studentTblTableAdapter;
        private System.Windows.Forms.BindingSource studentTblBindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ClassCb;
        private System.Windows.Forms.DataGridViewTextBoxColumn stIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stGenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stAddDataGridViewTextBoxColumn;
    }
}