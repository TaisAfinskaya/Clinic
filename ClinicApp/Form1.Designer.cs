namespace ClinicApp
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chDispancer = new System.Windows.Forms.CheckBox();
            this.chCanWork = new System.Windows.Forms.CheckBox();
            this.chAmbulance = new System.Windows.Forms.CheckBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtWithoutWork = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtDiagnose = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGetAllRecord = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRemoveRecord = new System.Windows.Forms.Button();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CPFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDiagnose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAmbulance = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CCanWork = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CWithoutWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDispancer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.txtDoctorPatronimic = new System.Windows.Forms.TextBox();
            this.txtDoctorLastName = new System.Windows.Forms.TextBox();
            this.txtDoctorFirstName = new System.Windows.Forms.TextBox();
            this.txtDoctorPosition = new System.Windows.Forms.TextBox();
            this.btnCancelUpdateDoctor = new System.Windows.Forms.Button();
            this.btnGetAllDoctors = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.btnRemoveDoctor = new System.Windows.Forms.Button();
            this.btnUpdateDoctor = new System.Windows.Forms.Button();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.dgDoctor = new System.Windows.Forms.DataGridView();
            this.CDPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDPatronimic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGetAllPatients = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateBth = new System.Windows.Forms.DateTimePicker();
            this.lbPatronimic = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.txtPatronomic = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.dgPatients = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatronimic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPatients = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctor)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatients)).BeginInit();
            this.tabPatients.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chDispancer);
            this.tabPage3.Controls.Add(this.chCanWork);
            this.tabPage3.Controls.Add(this.chAmbulance);
            this.tabPage3.Controls.Add(this.listBox2);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.txtWithoutWork);
            this.tabPage3.Controls.Add(this.txtNotes);
            this.tabPage3.Controls.Add(this.txtDiagnose);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.btnGetAllRecord);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.btnRemoveRecord);
            this.tabPage3.Controls.Add(this.btnUpdateRecord);
            this.tabPage3.Controls.Add(this.btnAddRecord);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1548, 649);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Записи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chDispancer
            // 
            this.chDispancer.AutoSize = true;
            this.chDispancer.Location = new System.Drawing.Point(1372, 366);
            this.chDispancer.Name = "chDispancer";
            this.chDispancer.Size = new System.Drawing.Size(70, 17);
            this.chDispancer.TabIndex = 59;
            this.chDispancer.Text = "На учете";
            this.chDispancer.UseVisualStyleBackColor = true;
            // 
            // chCanWork
            // 
            this.chCanWork.AutoSize = true;
            this.chCanWork.Location = new System.Drawing.Point(1204, 366);
            this.chCanWork.Name = "chCanWork";
            this.chCanWork.Size = new System.Drawing.Size(121, 17);
            this.chCanWork.TabIndex = 58;
            this.chCanWork.Text = "Трудоспособность";
            this.chCanWork.UseVisualStyleBackColor = true;
            this.chCanWork.CheckedChanged += new System.EventHandler(this.chCanWork_CheckedChanged);
            // 
            // chAmbulance
            // 
            this.chAmbulance.AutoSize = true;
            this.chAmbulance.Location = new System.Drawing.Point(1068, 366);
            this.chAmbulance.Name = "chAmbulance";
            this.chAmbulance.Size = new System.Drawing.Size(93, 17);
            this.chAmbulance.TabIndex = 57;
            this.chAmbulance.Text = "Амбулатория";
            this.chAmbulance.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(1275, 200);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 56;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1067, 200);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 55;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // txtWithoutWork
            // 
            this.txtWithoutWork.Location = new System.Drawing.Point(1204, 416);
            this.txtWithoutWork.Name = "txtWithoutWork";
            this.txtWithoutWork.Size = new System.Drawing.Size(100, 20);
            this.txtWithoutWork.TabIndex = 49;
            this.txtWithoutWork.Visible = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(1067, 457);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(464, 20);
            this.txtNotes.TabIndex = 41;
            // 
            // txtDiagnose
            // 
            this.txtDiagnose.Location = new System.Drawing.Point(1068, 314);
            this.txtDiagnose.Name = "txtDiagnose";
            this.txtDiagnose.Size = new System.Drawing.Size(100, 20);
            this.txtDiagnose.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1068, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(463, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Отмена обновления";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetAllRecord
            // 
            this.btnGetAllRecord.Location = new System.Drawing.Point(1059, 99);
            this.btnGetAllRecord.Name = "btnGetAllRecord";
            this.btnGetAllRecord.Size = new System.Drawing.Size(109, 23);
            this.btnGetAllRecord.TabIndex = 47;
            this.btnGetAllRecord.Text = "Все записи";
            this.btnGetAllRecord.UseVisualStyleBackColor = true;
            this.btnGetAllRecord.Click += new System.EventHandler(this.btnGetAllRecord_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1201, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Дней без работы";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1065, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Заметка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1065, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Диагноз";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1272, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Врач";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1065, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Пациент";
            // 
            // btnRemoveRecord
            // 
            this.btnRemoveRecord.Location = new System.Drawing.Point(1059, 70);
            this.btnRemoveRecord.Name = "btnRemoveRecord";
            this.btnRemoveRecord.Size = new System.Drawing.Size(109, 23);
            this.btnRemoveRecord.TabIndex = 37;
            this.btnRemoveRecord.Text = "Удалить запись";
            this.btnRemoveRecord.UseVisualStyleBackColor = true;
            this.btnRemoveRecord.Click += new System.EventHandler(this.btnRemoveRecord_Click);
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.Location = new System.Drawing.Point(1059, 41);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(109, 23);
            this.btnUpdateRecord.TabIndex = 36;
            this.btnUpdateRecord.Text = "Обновить запись";
            this.btnUpdateRecord.UseVisualStyleBackColor = true;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(1059, 12);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(109, 23);
            this.btnAddRecord.TabIndex = 35;
            this.btnAddRecord.Text = "Добавить запись";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPFullName,
            this.CDFullName,
            this.CDiagnose,
            this.CAmbulance,
            this.CCanWork,
            this.CWithoutWork,
            this.CDispancer,
            this.CNotes,
            this.RecordId});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 631);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // CPFullName
            // 
            this.CPFullName.HeaderText = "Пациент";
            this.CPFullName.Name = "CPFullName";
            this.CPFullName.ReadOnly = true;
            // 
            // CDFullName
            // 
            this.CDFullName.HeaderText = "Доктор";
            this.CDFullName.Name = "CDFullName";
            this.CDFullName.ReadOnly = true;
            // 
            // CDiagnose
            // 
            this.CDiagnose.HeaderText = "Диагноз";
            this.CDiagnose.Name = "CDiagnose";
            this.CDiagnose.ReadOnly = true;
            // 
            // CAmbulance
            // 
            this.CAmbulance.HeaderText = "Амбулатория";
            this.CAmbulance.Name = "CAmbulance";
            this.CAmbulance.ReadOnly = true;
            this.CAmbulance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CAmbulance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CCanWork
            // 
            this.CCanWork.HeaderText = "Трудоспособность";
            this.CCanWork.Name = "CCanWork";
            this.CCanWork.ReadOnly = true;
            this.CCanWork.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CCanWork.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CWithoutWork
            // 
            this.CWithoutWork.HeaderText = "Больничный (дней)";
            this.CWithoutWork.Name = "CWithoutWork";
            this.CWithoutWork.ReadOnly = true;
            // 
            // CDispancer
            // 
            this.CDispancer.HeaderText = "На учете";
            this.CDispancer.Name = "CDispancer";
            this.CDispancer.ReadOnly = true;
            // 
            // CNotes
            // 
            this.CNotes.HeaderText = "Заметка";
            this.CNotes.Name = "CNotes";
            this.CNotes.ReadOnly = true;
            // 
            // RecordId
            // 
            this.RecordId.HeaderText = "Column1";
            this.RecordId.Name = "RecordId";
            this.RecordId.ReadOnly = true;
            this.RecordId.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSpec);
            this.tabPage2.Controls.Add(this.txtDoctorPatronimic);
            this.tabPage2.Controls.Add(this.txtDoctorLastName);
            this.tabPage2.Controls.Add(this.txtDoctorFirstName);
            this.tabPage2.Controls.Add(this.txtDoctorPosition);
            this.tabPage2.Controls.Add(this.btnCancelUpdateDoctor);
            this.tabPage2.Controls.Add(this.btnGetAllDoctors);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lb);
            this.tabPage2.Controls.Add(this.btnRemoveDoctor);
            this.tabPage2.Controls.Add(this.btnUpdateDoctor);
            this.tabPage2.Controls.Add(this.btnAddDoctor);
            this.tabPage2.Controls.Add(this.dgDoctor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1548, 649);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Доктора";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(1255, 400);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(176, 20);
            this.txtSpec.TabIndex = 34;
            // 
            // txtDoctorPatronimic
            // 
            this.txtDoctorPatronimic.Location = new System.Drawing.Point(1255, 361);
            this.txtDoctorPatronimic.Name = "txtDoctorPatronimic";
            this.txtDoctorPatronimic.Size = new System.Drawing.Size(176, 20);
            this.txtDoctorPatronimic.TabIndex = 24;
            // 
            // txtDoctorLastName
            // 
            this.txtDoctorLastName.Location = new System.Drawing.Point(1255, 319);
            this.txtDoctorLastName.Name = "txtDoctorLastName";
            this.txtDoctorLastName.Size = new System.Drawing.Size(176, 20);
            this.txtDoctorLastName.TabIndex = 23;
            // 
            // txtDoctorFirstName
            // 
            this.txtDoctorFirstName.Location = new System.Drawing.Point(1255, 274);
            this.txtDoctorFirstName.Name = "txtDoctorFirstName";
            this.txtDoctorFirstName.Size = new System.Drawing.Size(176, 20);
            this.txtDoctorFirstName.TabIndex = 22;
            // 
            // txtDoctorPosition
            // 
            this.txtDoctorPosition.Location = new System.Drawing.Point(1255, 234);
            this.txtDoctorPosition.Name = "txtDoctorPosition";
            this.txtDoctorPosition.Size = new System.Drawing.Size(176, 20);
            this.txtDoctorPosition.TabIndex = 21;
            // 
            // btnCancelUpdateDoctor
            // 
            this.btnCancelUpdateDoctor.Location = new System.Drawing.Point(1255, 435);
            this.btnCancelUpdateDoctor.Name = "btnCancelUpdateDoctor";
            this.btnCancelUpdateDoctor.Size = new System.Drawing.Size(187, 23);
            this.btnCancelUpdateDoctor.TabIndex = 33;
            this.btnCancelUpdateDoctor.Text = "Отмена обновления";
            this.btnCancelUpdateDoctor.UseVisualStyleBackColor = true;
            this.btnCancelUpdateDoctor.Visible = false;
            this.btnCancelUpdateDoctor.Click += new System.EventHandler(this.btnCancelUpdateDoctor_Click);
            // 
            // btnGetAllDoctors
            // 
            this.btnGetAllDoctors.Location = new System.Drawing.Point(1246, 104);
            this.btnGetAllDoctors.Name = "btnGetAllDoctors";
            this.btnGetAllDoctors.Size = new System.Drawing.Size(196, 23);
            this.btnGetAllDoctors.TabIndex = 32;
            this.btnGetAllDoctors.Text = "Показать всех";
            this.btnGetAllDoctors.UseVisualStyleBackColor = true;
            this.btnGetAllDoctors.Click += new System.EventHandler(this.btnGetAllDoctors_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1252, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Специализация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1252, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1252, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1252, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Имя";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(1252, 218);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(65, 13);
            this.lb.TabIndex = 25;
            this.lb.Text = "Должность";
            // 
            // btnRemoveDoctor
            // 
            this.btnRemoveDoctor.Location = new System.Drawing.Point(1246, 75);
            this.btnRemoveDoctor.Name = "btnRemoveDoctor";
            this.btnRemoveDoctor.Size = new System.Drawing.Size(196, 23);
            this.btnRemoveDoctor.TabIndex = 20;
            this.btnRemoveDoctor.Text = "Исключить";
            this.btnRemoveDoctor.UseVisualStyleBackColor = true;
            this.btnRemoveDoctor.Click += new System.EventHandler(this.btnRemoveDoctor_Click);
            // 
            // btnUpdateDoctor
            // 
            this.btnUpdateDoctor.Location = new System.Drawing.Point(1246, 46);
            this.btnUpdateDoctor.Name = "btnUpdateDoctor";
            this.btnUpdateDoctor.Size = new System.Drawing.Size(196, 23);
            this.btnUpdateDoctor.TabIndex = 19;
            this.btnUpdateDoctor.Text = "Обновить";
            this.btnUpdateDoctor.UseVisualStyleBackColor = true;
            this.btnUpdateDoctor.Click += new System.EventHandler(this.btnUpdateDoctor_Click);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Location = new System.Drawing.Point(1246, 17);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(196, 23);
            this.btnAddDoctor.TabIndex = 18;
            this.btnAddDoctor.Text = "Добавить доктора";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // dgDoctor
            // 
            this.dgDoctor.AllowUserToAddRows = false;
            this.dgDoctor.AllowUserToDeleteRows = false;
            this.dgDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CDPosition,
            this.CDFirstName,
            this.CDLastName,
            this.CDPatronimic,
            this.CDSpec,
            this.CDId});
            this.dgDoctor.Location = new System.Drawing.Point(6, 3);
            this.dgDoctor.MultiSelect = false;
            this.dgDoctor.Name = "dgDoctor";
            this.dgDoctor.ReadOnly = true;
            this.dgDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDoctor.Size = new System.Drawing.Size(1216, 529);
            this.dgDoctor.TabIndex = 1;
            this.dgDoctor.SelectionChanged += new System.EventHandler(this.dgDoctor_SelectionChanged);
            // 
            // CDPosition
            // 
            this.CDPosition.HeaderText = "Должность";
            this.CDPosition.Name = "CDPosition";
            this.CDPosition.ReadOnly = true;
            // 
            // CDFirstName
            // 
            this.CDFirstName.HeaderText = "Имя";
            this.CDFirstName.Name = "CDFirstName";
            this.CDFirstName.ReadOnly = true;
            // 
            // CDLastName
            // 
            this.CDLastName.HeaderText = "Фамилия";
            this.CDLastName.Name = "CDLastName";
            this.CDLastName.ReadOnly = true;
            // 
            // CDPatronimic
            // 
            this.CDPatronimic.HeaderText = "Отчество";
            this.CDPatronimic.Name = "CDPatronimic";
            this.CDPatronimic.ReadOnly = true;
            // 
            // CDSpec
            // 
            this.CDSpec.HeaderText = "Специальность";
            this.CDSpec.Name = "CDSpec";
            this.CDSpec.ReadOnly = true;
            // 
            // CDId
            // 
            this.CDId.HeaderText = "Column1";
            this.CDId.Name = "CDId";
            this.CDId.ReadOnly = true;
            this.CDId.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgPatients);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1548, 649);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пациенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnGetAllPatients);
            this.panel1.Controls.Add(this.lbError);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateBth);
            this.panel1.Controls.Add(this.lbPatronimic);
            this.panel1.Controls.Add(this.lbLastName);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbNumber);
            this.panel1.Controls.Add(this.txtPatronomic);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAddPatient);
            this.panel1.Location = new System.Drawing.Point(1145, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 526);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(7, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Отмена обновления";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGetAllPatients
            // 
            this.btnGetAllPatients.Location = new System.Drawing.Point(7, 110);
            this.btnGetAllPatients.Name = "btnGetAllPatients";
            this.btnGetAllPatients.Size = new System.Drawing.Size(164, 23);
            this.btnGetAllPatients.TabIndex = 16;
            this.btnGetAllPatients.Text = "Список пациентов";
            this.btnGetAllPatients.UseVisualStyleBackColor = true;
            this.btnGetAllPatients.Click += new System.EventHandler(this.btnGetAllPatients_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(137, 486);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Дата Рождения";
            // 
            // dateBth
            // 
            this.dateBth.Location = new System.Drawing.Point(7, 350);
            this.dateBth.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateBth.MinDate = new System.DateTime(1919, 12, 31, 0, 0, 0, 0);
            this.dateBth.Name = "dateBth";
            this.dateBth.Size = new System.Drawing.Size(200, 20);
            this.dateBth.TabIndex = 12;
            // 
            // lbPatronimic
            // 
            this.lbPatronimic.AutoSize = true;
            this.lbPatronimic.Location = new System.Drawing.Point(4, 298);
            this.lbPatronimic.Name = "lbPatronimic";
            this.lbPatronimic.Size = new System.Drawing.Size(54, 13);
            this.lbPatronimic.TabIndex = 11;
            this.lbPatronimic.Text = "Отчество";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(4, 256);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(56, 13);
            this.lbLastName.TabIndex = 10;
            this.lbLastName.Text = "Фамилия";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(4, 211);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 13);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Имя";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Location = new System.Drawing.Point(4, 171);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(81, 13);
            this.lbNumber.TabIndex = 8;
            this.lbNumber.Text = "Номер (карты)";
            // 
            // txtPatronomic
            // 
            this.txtPatronomic.Location = new System.Drawing.Point(7, 314);
            this.txtPatronomic.Name = "txtPatronomic";
            this.txtPatronomic.Size = new System.Drawing.Size(164, 20);
            this.txtPatronomic.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(7, 272);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(164, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(7, 227);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(7, 187);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(164, 20);
            this.txtNumber.TabIndex = 4;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(7, 72);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(164, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Исключить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(7, 43);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(7, 14);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(164, 23);
            this.btnAddPatient.TabIndex = 1;
            this.btnAddPatient.Text = "Добавить пациента";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // dgPatients
            // 
            this.dgPatients.AllowUserToAddRows = false;
            this.dgPatients.AllowUserToDeleteRows = false;
            this.dgPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnFirstName,
            this.ColumnLastName,
            this.ColumnPatronimic,
            this.ColumnBth,
            this.Id});
            this.dgPatients.Location = new System.Drawing.Point(-4, 3);
            this.dgPatients.MultiSelect = false;
            this.dgPatients.Name = "dgPatients";
            this.dgPatients.ReadOnly = true;
            this.dgPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPatients.Size = new System.Drawing.Size(1132, 529);
            this.dgPatients.TabIndex = 0;
            this.dgPatients.SelectionChanged += new System.EventHandler(this.dgPatients_SelectionChanged);
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.HeaderText = "Номер (карта)";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            // 
            // ColumnFirstName
            // 
            this.ColumnFirstName.HeaderText = "Имя";
            this.ColumnFirstName.Name = "ColumnFirstName";
            this.ColumnFirstName.ReadOnly = true;
            // 
            // ColumnLastName
            // 
            this.ColumnLastName.HeaderText = "Фамилия";
            this.ColumnLastName.Name = "ColumnLastName";
            this.ColumnLastName.ReadOnly = true;
            // 
            // ColumnPatronimic
            // 
            this.ColumnPatronimic.HeaderText = "Отчество";
            this.ColumnPatronimic.Name = "ColumnPatronimic";
            this.ColumnPatronimic.ReadOnly = true;
            // 
            // ColumnBth
            // 
            this.ColumnBth.HeaderText = "Дата рождения";
            this.ColumnBth.Name = "ColumnBth";
            this.ColumnBth.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Column1";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // tabPatients
            // 
            this.tabPatients.Controls.Add(this.tabPage1);
            this.tabPatients.Controls.Add(this.tabPage2);
            this.tabPatients.Controls.Add(this.tabPage3);
            this.tabPatients.Location = new System.Drawing.Point(12, 12);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.SelectedIndex = 0;
            this.tabPatients.Size = new System.Drawing.Size(1556, 675);
            this.tabPatients.TabIndex = 2;
            this.tabPatients.Click += new System.EventHandler(this.tabPatients_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 699);
            this.Controls.Add(this.tabPatients);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctor)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatients)).EndInit();
            this.tabPatients.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.TextBox txtDoctorPatronimic;
        private System.Windows.Forms.TextBox txtDoctorLastName;
        private System.Windows.Forms.TextBox txtDoctorFirstName;
        private System.Windows.Forms.TextBox txtDoctorPosition;
        private System.Windows.Forms.Button btnCancelUpdateDoctor;
        private System.Windows.Forms.Button btnGetAllDoctors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button btnRemoveDoctor;
        private System.Windows.Forms.Button btnUpdateDoctor;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.DataGridView dgDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDPatronimic;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDId;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGetAllPatients;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateBth;
        private System.Windows.Forms.Label lbPatronimic;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.TextBox txtPatronomic;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.DataGridView dgPatients;
        private System.Windows.Forms.TabControl tabPatients;
        private System.Windows.Forms.TextBox txtWithoutWork;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtDiagnose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGetAllRecord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRemoveRecord;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.CheckBox chDispancer;
        private System.Windows.Forms.CheckBox chCanWork;
        private System.Windows.Forms.CheckBox chAmbulance;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDiagnose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CAmbulance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CCanWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn CWithoutWork;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CDispancer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatronimic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}

