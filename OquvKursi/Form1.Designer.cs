namespace OquvKursi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewAbiturient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.hisobotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmnuNewAbiturient = new System.Windows.Forms.ToolStripButton();
            this.tsmnuTeacher = new System.Windows.Forms.ToolStripButton();
            this.tsmnuCourse = new System.Windows.Forms.ToolStripButton();
            this.tscmbSubject = new System.Windows.Forms.ToolStripComboBox();
            this.tsmnuNewSubject = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvAbiturient = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPasportNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.clmId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPasportNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddress1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubject1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.clmId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubject2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbiturient)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.hisobotToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(832, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewSubject,
            this.mnuNewAbiturient,
            this.mnuNewTeacher,
            this.mnuNewCourse,
            this.mnuSave});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(45, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuNewSubject
            // 
            this.mnuNewSubject.Name = "mnuNewSubject";
            this.mnuNewSubject.Size = new System.Drawing.Size(201, 24);
            this.mnuNewSubject.Text = "Yangi fan qoshish";
            this.mnuNewSubject.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuNewAbiturient
            // 
            this.mnuNewAbiturient.Name = "mnuNewAbiturient";
            this.mnuNewAbiturient.Size = new System.Drawing.Size(201, 24);
            this.mnuNewAbiturient.Text = "Yangi abiturient";
            this.mnuNewAbiturient.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuNewTeacher
            // 
            this.mnuNewTeacher.Name = "mnuNewTeacher";
            this.mnuNewTeacher.Size = new System.Drawing.Size(201, 24);
            this.mnuNewTeacher.Text = "Yangi oqituvchi";
            this.mnuNewTeacher.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuNewCourse
            // 
            this.mnuNewCourse.Name = "mnuNewCourse";
            this.mnuNewCourse.Size = new System.Drawing.Size(201, 24);
            this.mnuNewCourse.Text = "Yangi kurs";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(201, 24);
            this.mnuSave.Text = "Saqlash";
            this.mnuSave.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // hisobotToolStripMenuItem
            // 
            this.hisobotToolStripMenuItem.Name = "hisobotToolStripMenuItem";
            this.hisobotToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.hisobotToolStripMenuItem.Text = "Hisobot";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuNewAbiturient,
            this.tsmnuTeacher,
            this.tsmnuCourse,
            this.tscmbSubject,
            this.tsmnuNewSubject,
            this.toolStripSeparator,
            this.tsbSave,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(832, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmnuNewAbiturient
            // 
            this.tsmnuNewAbiturient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmnuNewAbiturient.Image = global::OquvKursi.Properties.Resources._446424490_441880;
            this.tsmnuNewAbiturient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmnuNewAbiturient.Name = "tsmnuNewAbiturient";
            this.tsmnuNewAbiturient.Size = new System.Drawing.Size(23, 25);
            this.tsmnuNewAbiturient.Text = "toolStripButton1";
            this.tsmnuNewAbiturient.ToolTipText = "Yangi abiturient qo`shish";
            this.tsmnuNewAbiturient.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // tsmnuTeacher
            // 
            this.tsmnuTeacher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmnuTeacher.Image = global::OquvKursi.Properties.Resources._439634291_286145;
            this.tsmnuTeacher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmnuTeacher.Name = "tsmnuTeacher";
            this.tsmnuTeacher.Size = new System.Drawing.Size(23, 25);
            this.tsmnuTeacher.Text = "toolStripButton3";
            this.tsmnuTeacher.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // tsmnuCourse
            // 
            this.tsmnuCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmnuCourse.Image = global::OquvKursi.Properties.Resources._446738735_280931;
            this.tsmnuCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmnuCourse.Name = "tsmnuCourse";
            this.tsmnuCourse.Size = new System.Drawing.Size(23, 25);
            this.tsmnuCourse.Text = "toolStripButton1";
            this.tsmnuCourse.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // tscmbSubject
            // 
            this.tscmbSubject.Items.AddRange(new object[] {
            "Matematika",
            "Ingliz tili",
            "Fizika",
            "Informatika",
            "Ona tili",
            "Adabiyot"});
            this.tscmbSubject.Name = "tscmbSubject";
            this.tscmbSubject.Size = new System.Drawing.Size(121, 28);
            this.tscmbSubject.Text = "Fanlar";
            // 
            // tsmnuNewSubject
            // 
            this.tsmnuNewSubject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmnuNewSubject.Image = global::OquvKursi.Properties.Resources._446731977_126792;
            this.tsmnuNewSubject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmnuNewSubject.Name = "tsmnuNewSubject";
            this.tsmnuNewSubject.Size = new System.Drawing.Size(23, 25);
            this.tsmnuNewSubject.Text = "toolStripButton2";
            this.tsmnuNewSubject.ToolTipText = "Yangi fan qo`shish";
            this.tsmnuNewSubject.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 25);
            this.tsbSave.Text = "Ma\'lumotlarni saqlash";
            this.tsbSave.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 25);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 441);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvAbiturient);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(824, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Abiturientlar ro`yxati";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvAbiturient
            // 
            this.dgvAbiturient.AllowUserToAddRows = false;
            this.dgvAbiturient.AllowUserToDeleteRows = false;
            this.dgvAbiturient.AllowUserToResizeColumns = false;
            this.dgvAbiturient.AllowUserToResizeRows = false;
            this.dgvAbiturient.BackgroundColor = System.Drawing.Color.White;
            this.dgvAbiturient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbiturient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmLastName,
            this.clmName,
            this.clmSurName,
            this.clmPasportNumber,
            this.clmPol,
            this.clmAddress,
            this.clmPhoneNumber,
            this.clmSubject});
            this.dgvAbiturient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbiturient.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAbiturient.Location = new System.Drawing.Point(4, 4);
            this.dgvAbiturient.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAbiturient.Name = "dgvAbiturient";
            this.dgvAbiturient.Size = new System.Drawing.Size(816, 404);
            this.dgvAbiturient.TabIndex = 0;
            this.dgvAbiturient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbiturient_CellContentClick);
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            // 
            // clmLastName
            // 
            this.clmLastName.HeaderText = "Familiya";
            this.clmLastName.Name = "clmLastName";
            this.clmLastName.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Ism";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmSurName
            // 
            this.clmSurName.HeaderText = "Sharif";
            this.clmSurName.Name = "clmSurName";
            this.clmSurName.ReadOnly = true;
            // 
            // clmPasportNumber
            // 
            this.clmPasportNumber.HeaderText = "Pasport nomeri";
            this.clmPasportNumber.Name = "clmPasportNumber";
            this.clmPasportNumber.ReadOnly = true;
            this.clmPasportNumber.Width = 80;
            // 
            // clmPol
            // 
            this.clmPol.HeaderText = "Jins";
            this.clmPol.Name = "clmPol";
            this.clmPol.ReadOnly = true;
            // 
            // clmAddress
            // 
            this.clmAddress.HeaderText = "Manzil";
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.ReadOnly = true;
            // 
            // clmPhoneNumber
            // 
            this.clmPhoneNumber.HeaderText = "Telefon raqam";
            this.clmPhoneNumber.Name = "clmPhoneNumber";
            this.clmPhoneNumber.ReadOnly = true;
            this.clmPhoneNumber.Width = 80;
            // 
            // clmSubject
            // 
            this.clmSubject.HeaderText = "Fan";
            this.clmSubject.Name = "clmSubject";
            this.clmSubject.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTeacher);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(824, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "O\'qituvchilar ro\'yxati";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.BackgroundColor = System.Drawing.Color.White;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId1,
            this.clmLastName1,
            this.clmName1,
            this.clmSurName1,
            this.clmPasportNumber1,
            this.clmPol1,
            this.clmAddress1,
            this.clmPhoneNumber1,
            this.clmSubject1});
            this.dgvTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeacher.Location = new System.Drawing.Point(4, 4);
            this.dgvTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.Size = new System.Drawing.Size(816, 404);
            this.dgvTeacher.TabIndex = 0;
            // 
            // clmId1
            // 
            this.clmId1.HeaderText = "Id";
            this.clmId1.Name = "clmId1";
            this.clmId1.Visible = false;
            // 
            // clmLastName1
            // 
            this.clmLastName1.HeaderText = "Familiya";
            this.clmLastName1.Name = "clmLastName1";
            this.clmLastName1.ReadOnly = true;
            // 
            // clmName1
            // 
            this.clmName1.HeaderText = "Ism";
            this.clmName1.Name = "clmName1";
            this.clmName1.ReadOnly = true;
            // 
            // clmSurName1
            // 
            this.clmSurName1.HeaderText = "Sharif";
            this.clmSurName1.Name = "clmSurName1";
            this.clmSurName1.ReadOnly = true;
            // 
            // clmPasportNumber1
            // 
            this.clmPasportNumber1.HeaderText = "Pasport raqam";
            this.clmPasportNumber1.Name = "clmPasportNumber1";
            this.clmPasportNumber1.ReadOnly = true;
            // 
            // clmPol1
            // 
            this.clmPol1.HeaderText = "Jins";
            this.clmPol1.Name = "clmPol1";
            this.clmPol1.ReadOnly = true;
            // 
            // clmAddress1
            // 
            this.clmAddress1.HeaderText = "Manzil";
            this.clmAddress1.Name = "clmAddress1";
            this.clmAddress1.ReadOnly = true;
            // 
            // clmPhoneNumber1
            // 
            this.clmPhoneNumber1.HeaderText = "Telefon raqam";
            this.clmPhoneNumber1.Name = "clmPhoneNumber1";
            this.clmPhoneNumber1.ReadOnly = true;
            // 
            // clmSubject1
            // 
            this.clmSubject1.HeaderText = "Fan";
            this.clmSubject1.Name = "clmSubject1";
            this.clmSubject1.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvCourse);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(824, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kurslar ro\'yxati";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvCourse
            // 
            this.dgvCourse.AllowUserToAddRows = false;
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId2,
            this.clmName2,
            this.clmSubject2});
            this.dgvCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourse.Location = new System.Drawing.Point(4, 4);
            this.dgvCourse.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.Size = new System.Drawing.Size(816, 404);
            this.dgvCourse.TabIndex = 0;
            // 
            // clmId2
            // 
            this.clmId2.HeaderText = "Id";
            this.clmId2.Name = "clmId2";
            this.clmId2.ReadOnly = true;
            this.clmId2.Visible = false;
            // 
            // clmName2
            // 
            this.clmName2.HeaderText = "Kurs nomi";
            this.clmName2.Name = "clmName2";
            this.clmName2.ReadOnly = true;
            // 
            // clmSubject2
            // 
            this.clmSubject2.HeaderText = "Fan";
            this.clmSubject2.Name = "clmSubject2";
            this.clmSubject2.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 497);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbiturient)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNewSubject;
        private System.Windows.Forms.ToolStripMenuItem mnuNewAbiturient;
        private System.Windows.Forms.ToolStripMenuItem mnuNewTeacher;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsmnuNewAbiturient;
        private System.Windows.Forms.ToolStripButton tsmnuNewSubject;
        private System.Windows.Forms.ToolStripButton tsmnuTeacher;
        private System.Windows.Forms.ToolStripMenuItem mnuNewCourse;
        private System.Windows.Forms.ToolStripMenuItem hisobotToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsmnuCourse;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvAbiturient;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripComboBox tscmbSubject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubject2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPasportNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSurName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPasportNumber1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddress1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNumber1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubject1;
    }
}

