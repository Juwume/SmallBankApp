namespace SmallBankApp
{
    partial class DCFizFaces
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurTextBox = new System.Windows.Forms.TextBox();
            this.PatTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DepGridView = new System.Windows.Forms.DataGridView();
            this.idDepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smallBankDataSet = new SmallBankApp.SmallBankDataSet();
            this.depositsTableAdapter = new SmallBankApp.SmallBankDataSetTableAdapters.DepositsTableAdapter();
            this.CredGridView = new System.Windows.Forms.DataGridView();
            this.idCredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExpDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTarifDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditsTableAdapter = new SmallBankApp.SmallBankDataSetTableAdapters.CreditsTableAdapter();
            this.ClientsGridView = new System.Windows.Forms.DataGridView();
            this.idClientDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fizFacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fizFacesTableAdapter = new SmallBankApp.SmallBankDataSetTableAdapters.FizFacesTableAdapter();
            this.AddDepButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddCredButton = new System.Windows.Forms.Button();
            this.DelDepButton = new System.Windows.Forms.Button();
            this.DelCredButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DepGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CredGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fizFacesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(670, 99);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(159, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // SurTextBox
            // 
            this.SurTextBox.Location = new System.Drawing.Point(670, 132);
            this.SurTextBox.Name = "SurTextBox";
            this.SurTextBox.Size = new System.Drawing.Size(159, 20);
            this.SurTextBox.TabIndex = 1;
            // 
            // PatTextBox
            // 
            this.PatTextBox.Location = new System.Drawing.Point(670, 161);
            this.PatTextBox.Name = "PatTextBox";
            this.PatTextBox.Size = new System.Drawing.Size(159, 20);
            this.PatTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(531, 95);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(46, 24);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Имя";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(531, 127);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(91, 24);
            this.SurnameLabel.TabIndex = 4;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(531, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // DepGridView
            // 
            this.DepGridView.AllowUserToAddRows = false;
            this.DepGridView.AllowUserToDeleteRows = false;
            this.DepGridView.AutoGenerateColumns = false;
            this.DepGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn,
            this.summDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn,
            this.dateExpDataGridViewTextBoxColumn,
            this.idTarifDataGridViewTextBoxColumn});
            this.DepGridView.DataSource = this.depositsBindingSource;
            this.DepGridView.Location = new System.Drawing.Point(75, 263);
            this.DepGridView.Name = "DepGridView";
            this.DepGridView.Size = new System.Drawing.Size(754, 150);
            this.DepGridView.TabIndex = 6;
            this.DepGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DepGridView_RowHeaderMouseClick);
            // 
            // idDepDataGridViewTextBoxColumn
            // 
            this.idDepDataGridViewTextBoxColumn.DataPropertyName = "IdDep";
            this.idDepDataGridViewTextBoxColumn.HeaderText = "IdDep";
            this.idDepDataGridViewTextBoxColumn.Name = "idDepDataGridViewTextBoxColumn";
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            // 
            // summDataGridViewTextBoxColumn
            // 
            this.summDataGridViewTextBoxColumn.DataPropertyName = "Summ";
            this.summDataGridViewTextBoxColumn.HeaderText = "Summ";
            this.summDataGridViewTextBoxColumn.Name = "summDataGridViewTextBoxColumn";
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            this.dateStartDataGridViewTextBoxColumn.DataPropertyName = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.HeaderText = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            // 
            // dateExpDataGridViewTextBoxColumn
            // 
            this.dateExpDataGridViewTextBoxColumn.DataPropertyName = "DateExp";
            this.dateExpDataGridViewTextBoxColumn.HeaderText = "DateExp";
            this.dateExpDataGridViewTextBoxColumn.Name = "dateExpDataGridViewTextBoxColumn";
            // 
            // idTarifDataGridViewTextBoxColumn
            // 
            this.idTarifDataGridViewTextBoxColumn.DataPropertyName = "IdTarif";
            this.idTarifDataGridViewTextBoxColumn.HeaderText = "IdTarif";
            this.idTarifDataGridViewTextBoxColumn.Name = "idTarifDataGridViewTextBoxColumn";
            // 
            // depositsBindingSource
            // 
            this.depositsBindingSource.DataMember = "Deposits";
            this.depositsBindingSource.DataSource = this.smallBankDataSet;
            // 
            // smallBankDataSet
            // 
            this.smallBankDataSet.DataSetName = "SmallBankDataSet";
            this.smallBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depositsTableAdapter
            // 
            this.depositsTableAdapter.ClearBeforeFill = true;
            // 
            // CredGridView
            // 
            this.CredGridView.AllowUserToAddRows = false;
            this.CredGridView.AllowUserToDeleteRows = false;
            this.CredGridView.AutoGenerateColumns = false;
            this.CredGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CredGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCredDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn1,
            this.summDataGridViewTextBoxColumn1,
            this.restDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn1,
            this.dateExpDataGridViewTextBoxColumn1,
            this.idTarifDataGridViewTextBoxColumn1});
            this.CredGridView.DataSource = this.creditsBindingSource;
            this.CredGridView.Location = new System.Drawing.Point(75, 433);
            this.CredGridView.Name = "CredGridView";
            this.CredGridView.Size = new System.Drawing.Size(754, 150);
            this.CredGridView.TabIndex = 7;
            this.CredGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CredGridView_RowHeaderMouseClick);
            // 
            // idCredDataGridViewTextBoxColumn
            // 
            this.idCredDataGridViewTextBoxColumn.DataPropertyName = "IdCred";
            this.idCredDataGridViewTextBoxColumn.HeaderText = "IdCred";
            this.idCredDataGridViewTextBoxColumn.Name = "idCredDataGridViewTextBoxColumn";
            // 
            // idClientDataGridViewTextBoxColumn1
            // 
            this.idClientDataGridViewTextBoxColumn1.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn1.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn1.Name = "idClientDataGridViewTextBoxColumn1";
            // 
            // summDataGridViewTextBoxColumn1
            // 
            this.summDataGridViewTextBoxColumn1.DataPropertyName = "Summ";
            this.summDataGridViewTextBoxColumn1.HeaderText = "Summ";
            this.summDataGridViewTextBoxColumn1.Name = "summDataGridViewTextBoxColumn1";
            // 
            // restDataGridViewTextBoxColumn
            // 
            this.restDataGridViewTextBoxColumn.DataPropertyName = "Rest";
            this.restDataGridViewTextBoxColumn.HeaderText = "Rest";
            this.restDataGridViewTextBoxColumn.Name = "restDataGridViewTextBoxColumn";
            // 
            // dateStartDataGridViewTextBoxColumn1
            // 
            this.dateStartDataGridViewTextBoxColumn1.DataPropertyName = "DateStart";
            this.dateStartDataGridViewTextBoxColumn1.HeaderText = "DateStart";
            this.dateStartDataGridViewTextBoxColumn1.Name = "dateStartDataGridViewTextBoxColumn1";
            // 
            // dateExpDataGridViewTextBoxColumn1
            // 
            this.dateExpDataGridViewTextBoxColumn1.DataPropertyName = "DateExp";
            this.dateExpDataGridViewTextBoxColumn1.HeaderText = "DateExp";
            this.dateExpDataGridViewTextBoxColumn1.Name = "dateExpDataGridViewTextBoxColumn1";
            // 
            // idTarifDataGridViewTextBoxColumn1
            // 
            this.idTarifDataGridViewTextBoxColumn1.DataPropertyName = "IdTarif";
            this.idTarifDataGridViewTextBoxColumn1.HeaderText = "IdTarif";
            this.idTarifDataGridViewTextBoxColumn1.Name = "idTarifDataGridViewTextBoxColumn1";
            // 
            // creditsBindingSource
            // 
            this.creditsBindingSource.DataMember = "Credits";
            this.creditsBindingSource.DataSource = this.smallBankDataSet;
            // 
            // creditsTableAdapter
            // 
            this.creditsTableAdapter.ClearBeforeFill = true;
            // 
            // ClientsGridView
            // 
            this.ClientsGridView.AutoGenerateColumns = false;
            this.ClientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientDataGridViewTextBoxColumn2,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.ClientsGridView.DataSource = this.fizFacesBindingSource;
            this.ClientsGridView.Location = new System.Drawing.Point(75, 34);
            this.ClientsGridView.Name = "ClientsGridView";
            this.ClientsGridView.Size = new System.Drawing.Size(450, 207);
            this.ClientsGridView.TabIndex = 8;
            this.ClientsGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClientsGridView_RowHeaderMouseClick);
            // 
            // idClientDataGridViewTextBoxColumn2
            // 
            this.idClientDataGridViewTextBoxColumn2.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.idClientDataGridViewTextBoxColumn2.Name = "idClientDataGridViewTextBoxColumn2";
            this.idClientDataGridViewTextBoxColumn2.Width = 40;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.Width = 120;
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "INN";
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            this.iNNDataGridViewTextBoxColumn.Visible = false;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.Visible = false;
            // 
            // fizFacesBindingSource
            // 
            this.fizFacesBindingSource.DataMember = "FizFaces";
            this.fizFacesBindingSource.DataSource = this.smallBankDataSet;
            // 
            // fizFacesTableAdapter
            // 
            this.fizFacesTableAdapter.ClearBeforeFill = true;
            // 
            // AddDepButton
            // 
            this.AddDepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDepButton.Location = new System.Drawing.Point(835, 263);
            this.AddDepButton.Name = "AddDepButton";
            this.AddDepButton.Size = new System.Drawing.Size(82, 47);
            this.AddDepButton.TabIndex = 10;
            this.AddDepButton.Text = "Добавить";
            this.AddDepButton.UseVisualStyleBackColor = true;
            this.AddDepButton.Click += new System.EventHandler(this.AddDepButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(670, 199);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(159, 42);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddCredButton
            // 
            this.AddCredButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCredButton.Location = new System.Drawing.Point(835, 433);
            this.AddCredButton.Name = "AddCredButton";
            this.AddCredButton.Size = new System.Drawing.Size(82, 47);
            this.AddCredButton.TabIndex = 12;
            this.AddCredButton.Text = "Добавить";
            this.AddCredButton.UseVisualStyleBackColor = true;
            this.AddCredButton.Click += new System.EventHandler(this.AddCredButton_Click);
            // 
            // DelDepButton
            // 
            this.DelDepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelDepButton.Location = new System.Drawing.Point(835, 316);
            this.DelDepButton.Name = "DelDepButton";
            this.DelDepButton.Size = new System.Drawing.Size(82, 47);
            this.DelDepButton.TabIndex = 13;
            this.DelDepButton.Text = "Удалить";
            this.DelDepButton.UseVisualStyleBackColor = true;
            this.DelDepButton.Click += new System.EventHandler(this.DelDepButton_Click);
            // 
            // DelCredButton
            // 
            this.DelCredButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelCredButton.Location = new System.Drawing.Point(835, 486);
            this.DelCredButton.Name = "DelCredButton";
            this.DelCredButton.Size = new System.Drawing.Size(82, 47);
            this.DelCredButton.TabIndex = 14;
            this.DelCredButton.Text = "Удалить";
            this.DelCredButton.UseVisualStyleBackColor = true;
            this.DelCredButton.Click += new System.EventHandler(this.DelCredButton_Click);
            // 
            // DCFizFaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 604);
            this.Controls.Add(this.DelCredButton);
            this.Controls.Add(this.DelDepButton);
            this.Controls.Add(this.AddCredButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddDepButton);
            this.Controls.Add(this.ClientsGridView);
            this.Controls.Add(this.CredGridView);
            this.Controls.Add(this.DepGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PatTextBox);
            this.Controls.Add(this.SurTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Location = new System.Drawing.Point(-100, -100);
            this.Name = "DCFizFaces";
            this.Text = "DCFizFaces";
            this.Activated += new System.EventHandler(this.DCFizFaces_Activated);
            this.Load += new System.EventHandler(this.DCFizFaces_Load);
            this.Click += new System.EventHandler(this.DCFizFaces_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DepGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CredGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fizFacesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurTextBox;
        private System.Windows.Forms.TextBox PatTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DepGridView;
        private SmallBankDataSet smallBankDataSet;
        private System.Windows.Forms.BindingSource depositsBindingSource;
        private SmallBankDataSetTableAdapters.DepositsTableAdapter depositsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView CredGridView;
        private System.Windows.Forms.BindingSource creditsBindingSource;
        private SmallBankDataSetTableAdapters.CreditsTableAdapter creditsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn summDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn restDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExpDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTarifDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView ClientsGridView;
        private System.Windows.Forms.BindingSource fizFacesBindingSource;
        private SmallBankDataSetTableAdapters.FizFacesTableAdapter fizFacesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddDepButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddCredButton;
        private System.Windows.Forms.Button DelDepButton;
        private System.Windows.Forms.Button DelCredButton;
    }
}