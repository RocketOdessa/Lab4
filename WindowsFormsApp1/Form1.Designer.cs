namespace InvestorsDB
{
    partial class FormDb
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.investors = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummaVklada = new System.Windows.Forms.Label();
            this.txtsumView = new System.Windows.Forms.TextBox();
            this.ToSave = new System.Windows.Forms.Button();
            this.txtTermView = new System.Windows.Forms.TextBox();
            this.txtAddressView = new System.Windows.Forms.TextBox();
            this.txtContractNumberView = new System.Windows.Forms.TextBox();
            this.srokDogovora = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.NomerDogovora = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.txtSurnameView = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSecondNameView = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.txtNameView = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.investorsEdit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTermSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSumSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSurnameSearch = new System.Windows.Forms.TextBox();
            this.SearchView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.считатьДанныеИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.investors)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.investorsEdit)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1146, 329);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.investors);
            this.tabPage1.Controls.Add(this.SummaVklada);
            this.tabPage1.Controls.Add(this.txtsumView);
            this.tabPage1.Controls.Add(this.ToSave);
            this.tabPage1.Controls.Add(this.txtTermView);
            this.tabPage1.Controls.Add(this.txtAddressView);
            this.tabPage1.Controls.Add(this.txtContractNumberView);
            this.tabPage1.Controls.Add(this.srokDogovora);
            this.tabPage1.Controls.Add(this.Address);
            this.tabPage1.Controls.Add(this.NomerDogovora);
            this.tabPage1.Controls.Add(this.LastName);
            this.tabPage1.Controls.Add(this.txtSurnameView);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtSecondNameView);
            this.tabPage1.Controls.Add(this.FirstName);
            this.tabPage1.Controls.Add(this.txtNameView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage1.Size = new System.Drawing.Size(1138, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Инвесторы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // investors
            // 
            this.investors.AllowUserToDeleteRows = false;
            this.investors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.investors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.investors.Location = new System.Drawing.Point(234, 0);
            this.investors.Name = "investors";
            this.investors.Size = new System.Drawing.Size(908, 300);
            this.investors.TabIndex = 51;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "№";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 25;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "SurName";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Name";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "ContractNumber";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Address";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 150;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Amount of Deposit";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "Term of the Contract";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 90;
            // 
            // SummaVklada
            // 
            this.SummaVklada.AutoSize = true;
            this.SummaVklada.Location = new System.Drawing.Point(1, 186);
            this.SummaVklada.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.SummaVklada.Name = "SummaVklada";
            this.SummaVklada.Size = new System.Drawing.Size(94, 13);
            this.SummaVklada.TabIndex = 50;
            this.SummaVklada.Text = "Amount of Deposit";
            // 
            // txtsumView
            // 
            this.txtsumView.Location = new System.Drawing.Point(117, 183);
            this.txtsumView.Margin = new System.Windows.Forms.Padding(1);
            this.txtsumView.Name = "txtsumView";
            this.txtsumView.Size = new System.Drawing.Size(107, 20);
            this.txtsumView.TabIndex = 6;
            // 
            // ToSave
            // 
            this.ToSave.Location = new System.Drawing.Point(62, 279);
            this.ToSave.Name = "ToSave";
            this.ToSave.Size = new System.Drawing.Size(107, 21);
            this.ToSave.TabIndex = 8;
            this.ToSave.Text = "Save to base";
            this.ToSave.UseVisualStyleBackColor = true;
            this.ToSave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtTermView
            // 
            this.txtTermView.Location = new System.Drawing.Point(117, 221);
            this.txtTermView.Margin = new System.Windows.Forms.Padding(1);
            this.txtTermView.Name = "txtTermView";
            this.txtTermView.Size = new System.Drawing.Size(107, 20);
            this.txtTermView.TabIndex = 7;
            // 
            // txtAddressView
            // 
            this.txtAddressView.Location = new System.Drawing.Point(117, 149);
            this.txtAddressView.Margin = new System.Windows.Forms.Padding(1);
            this.txtAddressView.Name = "txtAddressView";
            this.txtAddressView.Size = new System.Drawing.Size(107, 20);
            this.txtAddressView.TabIndex = 5;
            // 
            // txtContractNumberView
            // 
            this.txtContractNumberView.Location = new System.Drawing.Point(117, 120);
            this.txtContractNumberView.Margin = new System.Windows.Forms.Padding(1);
            this.txtContractNumberView.Name = "txtContractNumberView";
            this.txtContractNumberView.Size = new System.Drawing.Size(107, 20);
            this.txtContractNumberView.TabIndex = 4;
            // 
            // srokDogovora
            // 
            this.srokDogovora.AutoSize = true;
            this.srokDogovora.Location = new System.Drawing.Point(2, 224);
            this.srokDogovora.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.srokDogovora.Name = "srokDogovora";
            this.srokDogovora.Size = new System.Drawing.Size(103, 13);
            this.srokDogovora.TabIndex = 44;
            this.srokDogovora.Text = "Term of the contract";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(1, 152);
            this.Address.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 43;
            this.Address.Text = "Address";
            // 
            // NomerDogovora
            // 
            this.NomerDogovora.AutoSize = true;
            this.NomerDogovora.Location = new System.Drawing.Point(1, 114);
            this.NomerDogovora.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.NomerDogovora.Name = "NomerDogovora";
            this.NomerDogovora.Size = new System.Drawing.Size(85, 26);
            this.NomerDogovora.TabIndex = 42;
            this.NomerDogovora.Text = "\r\nContract number";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(1, 88);
            this.LastName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(55, 13);
            this.LastName.TabIndex = 41;
            this.LastName.Text = "LastName";
            // 
            // txtSurnameView
            // 
            this.txtSurnameView.Location = new System.Drawing.Point(117, 14);
            this.txtSurnameView.Margin = new System.Windows.Forms.Padding(1);
            this.txtSurnameView.Name = "txtSurnameView";
            this.txtSurnameView.Size = new System.Drawing.Size(107, 20);
            this.txtSurnameView.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "SurName";
            // 
            // txtSecondNameView
            // 
            this.txtSecondNameView.Location = new System.Drawing.Point(117, 85);
            this.txtSecondNameView.Margin = new System.Windows.Forms.Padding(1);
            this.txtSecondNameView.Name = "txtSecondNameView";
            this.txtSecondNameView.Size = new System.Drawing.Size(107, 20);
            this.txtSecondNameView.TabIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(2, 48);
            this.FirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(35, 13);
            this.FirstName.TabIndex = 37;
            this.FirstName.Text = "Name";
            // 
            // txtNameView
            // 
            this.txtNameView.Location = new System.Drawing.Point(117, 45);
            this.txtNameView.Margin = new System.Windows.Forms.Padding(1);
            this.txtNameView.Name = "txtNameView";
            this.txtNameView.Size = new System.Drawing.Size(107, 20);
            this.txtNameView.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.investorsEdit);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage2.Size = new System.Drawing.Size(1138, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Правка";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // investorsEdit
            // 
            this.investorsEdit.AllowUserToDeleteRows = false;
            this.investorsEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.investorsEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn13});
            this.investorsEdit.Location = new System.Drawing.Point(0, 0);
            this.investorsEdit.Name = "investorsEdit";
            this.investorsEdit.Size = new System.Drawing.Size(908, 300);
            this.investorsEdit.TabIndex = 52;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "SurName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Contract number";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Address";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Amount of deposit";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Term of the Contract";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 90;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(987, 208);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 24);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtTermSearch);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtSumSearch);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtSurnameSearch);
            this.tabPage3.Controls.Add(this.SearchView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1138, 303);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Поиск";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(78, 243);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 57);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete Investor by SurName";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(78, 144);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 93);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "TERM high";
            // 
            // txtTermSearch
            // 
            this.txtTermSearch.Location = new System.Drawing.Point(106, 90);
            this.txtTermSearch.Margin = new System.Windows.Forms.Padding(1);
            this.txtTermSearch.Name = "txtTermSearch";
            this.txtTermSearch.Size = new System.Drawing.Size(107, 20);
            this.txtTermSearch.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Deposit";
            // 
            // txtSumSearch
            // 
            this.txtSumSearch.Location = new System.Drawing.Point(106, 56);
            this.txtSumSearch.Margin = new System.Windows.Forms.Padding(1);
            this.txtSumSearch.Name = "txtSumSearch";
            this.txtSumSearch.Size = new System.Drawing.Size(107, 20);
            this.txtSumSearch.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "SurName";
            // 
            // txtSurnameSearch
            // 
            this.txtSurnameSearch.Location = new System.Drawing.Point(106, 23);
            this.txtSurnameSearch.Margin = new System.Windows.Forms.Padding(1);
            this.txtSurnameSearch.Name = "txtSurnameSearch";
            this.txtSurnameSearch.Size = new System.Drawing.Size(107, 20);
            this.txtSurnameSearch.TabIndex = 50;
            // 
            // SearchView
            // 
            this.SearchView.AllowUserToDeleteRows = false;
            this.SearchView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.Surname,
            this.Name,
            this.SecondName,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.SearchView.Location = new System.Drawing.Point(230, 0);
            this.SearchView.Name = "SearchView";
            this.SearchView.Size = new System.Drawing.Size(908, 300);
            this.SearchView.TabIndex = 49;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "№";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 25;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "SurName";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 125;
            // 
            // SecondName
            // 
            this.SecondName.HeaderText = "LastName";
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            this.SecondName.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Contract number";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Address";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Amount of deposit";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Term of the contract";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 90;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1147, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьВФайлToolStripMenuItem,
            this.считатьДанныеИзФайлаToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 22);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьВФайлToolStripMenuItem
            // 
            this.сохранитьВФайлToolStripMenuItem.Name = "сохранитьВФайлToolStripMenuItem";
            this.сохранитьВФайлToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.сохранитьВФайлToolStripMenuItem.Text = "Сохранить в файл";
            this.сохранитьВФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВФайлToolStripMenuItem_Click);
            // 
            // считатьДанныеИзФайлаToolStripMenuItem
            // 
            this.считатьДанныеИзФайлаToolStripMenuItem.Name = "считатьДанныеИзФайлаToolStripMenuItem";
            this.считатьДанныеИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.считатьДанныеИзФайлаToolStripMenuItem.Text = "Считать данные из файла";
        
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutToolStripMenuItem.Text = "Об программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // FormDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 353);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
          
            this.Text = "Investors database";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.investors)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.investorsEdit)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTermView;
        private System.Windows.Forms.TextBox txtAddressView;
        private System.Windows.Forms.TextBox txtContractNumberView;
        private System.Windows.Forms.Label srokDogovora;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label NomerDogovora;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox txtSurnameView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSecondNameView;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox txtNameView;
        private System.Windows.Forms.Button ToSave;
        private System.Windows.Forms.Label SummaVklada;
        private System.Windows.Forms.TextBox txtsumView;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВФайлToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTermSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSumSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSurnameSearch;
        private System.Windows.Forms.DataGridView SearchView;
        private System.Windows.Forms.DataGridView investors;
        private System.Windows.Forms.DataGridView investorsEdit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem считатьДанныеИзФайлаToolStripMenuItem;
    }
}

