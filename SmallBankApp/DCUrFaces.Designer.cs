namespace SmallBankApp
{
    partial class DCUrFaces
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
            this.DelCredButton = new System.Windows.Forms.Button();
            this.DelDepButton = new System.Windows.Forms.Button();
            this.AddCredButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddDepButton = new System.Windows.Forms.Button();
            this.ClientsGridView = new System.Windows.Forms.DataGridView();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urFacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smallBankDataSet = new SmallBankApp.SmallBankDataSet();
            this.CredGridView = new System.Windows.Forms.DataGridView();
            this.idCredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExpDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTarifDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DepGridView = new System.Windows.Forms.DataGridView();
            this.idDepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ShortNameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.urFacesTableAdapter = new SmallBankApp.SmallBankDataSetTableAdapters.UrFacesTableAdapter();
            this.depositsTableAdapter = new SmallBankApp.SmallBankDataSetTableAdapters.DepositsTableAdapter();
            this.creditsTableAdapter = new SmallBankApp.SmallBankDataSetTableAdapters.CreditsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urFacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CredGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DelCredButton
            // 
            this.DelCredButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelCredButton.Location = new System.Drawing.Point(798, 464);
            this.DelCredButton.Name = "DelCredButton";
            this.DelCredButton.Size = new System.Drawing.Size(82, 47);
            this.DelCredButton.TabIndex = 28;
            this.DelCredButton.Text = "Удалить";
            this.DelCredButton.UseVisualStyleBackColor = true;
            this.DelCredButton.Click += new System.EventHandler(this.DelCredButton_Click);
            // 
            // DelDepButton
            // 
            this.DelDepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelDepButton.Location = new System.Drawing.Point(798, 294);
            this.DelDepButton.Name = "DelDepButton";
            this.DelDepButton.Size = new System.Drawing.Size(82, 47);
            this.DelDepButton.TabIndex = 27;
            this.DelDepButton.Text = "Удалить";
            this.DelDepButton.UseVisualStyleBackColor = true;
            this.DelDepButton.Click += new System.EventHandler(this.DelDepButton_Click);
            // 
            // AddCredButton
            // 
            this.AddCredButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCredButton.Location = new System.Drawing.Point(798, 411);
            this.AddCredButton.Name = "AddCredButton";
            this.AddCredButton.Size = new System.Drawing.Size(82, 47);
            this.AddCredButton.TabIndex = 26;
            this.AddCredButton.Text = "Добавить";
            this.AddCredButton.UseVisualStyleBackColor = true;
            this.AddCredButton.Click += new System.EventHandler(this.AddCredButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(498, 177);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(159, 42);
            this.ExitButton.TabIndex = 25;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddDepButton
            // 
            this.AddDepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDepButton.Location = new System.Drawing.Point(798, 241);
            this.AddDepButton.Name = "AddDepButton";
            this.AddDepButton.Size = new System.Drawing.Size(82, 47);
            this.AddDepButton.TabIndex = 24;
            this.AddDepButton.Text = "Добавить";
            this.AddDepButton.UseVisualStyleBackColor = true;
            this.AddDepButton.Click += new System.EventHandler(this.AddDepButton_Click);
            // 
            // ClientsGridView
            // 
            this.ClientsGridView.AllowUserToAddRows = false;
            this.ClientsGridView.AllowUserToDeleteRows = false;
            this.ClientsGridView.AutoGenerateColumns = false;
            this.ClientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.shortNameDataGridViewTextBoxColumn,
            this.cPPDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.ClientsGridView.DataSource = this.urFacesBindingSource;
            this.ClientsGridView.Location = new System.Drawing.Point(38, 12);
            this.ClientsGridView.Name = "ClientsGridView";
            this.ClientsGridView.Size = new System.Drawing.Size(414, 189);
            this.ClientsGridView.TabIndex = 23;
            this.ClientsGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClientsGridView_RowHeaderMouseClick);
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // shortNameDataGridViewTextBoxColumn
            // 
            this.shortNameDataGridViewTextBoxColumn.DataPropertyName = "ShortName";
            this.shortNameDataGridViewTextBoxColumn.HeaderText = "ShortName";
            this.shortNameDataGridViewTextBoxColumn.Name = "shortNameDataGridViewTextBoxColumn";
            this.shortNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // cPPDataGridViewTextBoxColumn
            // 
            this.cPPDataGridViewTextBoxColumn.DataPropertyName = "CPP";
            this.cPPDataGridViewTextBoxColumn.HeaderText = "CPP";
            this.cPPDataGridViewTextBoxColumn.Name = "cPPDataGridViewTextBoxColumn";
            this.cPPDataGridViewTextBoxColumn.Visible = false;
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
            // urFacesBindingSource
            // 
            this.urFacesBindingSource.DataMember = "UrFaces";
            this.urFacesBindingSource.DataSource = this.smallBankDataSet;
            // 
            // smallBankDataSet
            // 
            this.smallBankDataSet.DataSetName = "SmallBankDataSet";
            this.smallBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CredGridView
            // 
            this.CredGridView.AllowUserToAddRows = false;
            this.CredGridView.AllowUserToDeleteRows = false;
            this.CredGridView.AutoGenerateColumns = false;
            this.CredGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CredGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCredDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn2,
            this.summDataGridViewTextBoxColumn1,
            this.restDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn1,
            this.dateExpDataGridViewTextBoxColumn1,
            this.idTarifDataGridViewTextBoxColumn1});
            this.CredGridView.DataSource = this.creditsBindingSource;
            this.CredGridView.Location = new System.Drawing.Point(38, 411);
            this.CredGridView.Name = "CredGridView";
            this.CredGridView.Size = new System.Drawing.Size(754, 150);
            this.CredGridView.TabIndex = 22;
            this.CredGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CredGridView_RowHeaderMouseClick);
            // 
            // idCredDataGridViewTextBoxColumn
            // 
            this.idCredDataGridViewTextBoxColumn.DataPropertyName = "IdCred";
            this.idCredDataGridViewTextBoxColumn.HeaderText = "IdCred";
            this.idCredDataGridViewTextBoxColumn.Name = "idCredDataGridViewTextBoxColumn";
            // 
            // idClientDataGridViewTextBoxColumn2
            // 
            this.idClientDataGridViewTextBoxColumn2.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn2.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn2.Name = "idClientDataGridViewTextBoxColumn2";
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
            // DepGridView
            // 
            this.DepGridView.AllowUserToAddRows = false;
            this.DepGridView.AllowUserToDeleteRows = false;
            this.DepGridView.AutoGenerateColumns = false;
            this.DepGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn1,
            this.summDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn,
            this.dateExpDataGridViewTextBoxColumn,
            this.idTarifDataGridViewTextBoxColumn});
            this.DepGridView.DataSource = this.depositsBindingSource;
            this.DepGridView.Location = new System.Drawing.Point(38, 241);
            this.DepGridView.Name = "DepGridView";
            this.DepGridView.Size = new System.Drawing.Size(754, 144);
            this.DepGridView.TabIndex = 21;
            this.DepGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DepGridView_RowHeaderMouseClick);
            // 
            // idDepDataGridViewTextBoxColumn
            // 
            this.idDepDataGridViewTextBoxColumn.DataPropertyName = "IdDep";
            this.idDepDataGridViewTextBoxColumn.HeaderText = "IdDep";
            this.idDepDataGridViewTextBoxColumn.Name = "idDepDataGridViewTextBoxColumn";
            // 
            // idClientDataGridViewTextBoxColumn1
            // 
            this.idClientDataGridViewTextBoxColumn1.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn1.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn1.Name = "idClientDataGridViewTextBoxColumn1";
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
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(494, 106);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(186, 24);
            this.SurnameLabel.TabIndex = 19;
            this.SurnameLabel.Text = "Короткое название";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(494, 73);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(97, 24);
            this.NameLabel.TabIndex = 18;
            this.NameLabel.Text = "Название";
            // 
            // ShortNameTextBox
            // 
            this.ShortNameTextBox.Location = new System.Drawing.Point(690, 111);
            this.ShortNameTextBox.Name = "ShortNameTextBox";
            this.ShortNameTextBox.Size = new System.Drawing.Size(159, 20);
            this.ShortNameTextBox.TabIndex = 16;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(690, 78);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(159, 20);
            this.NameTextBox.TabIndex = 15;
            // 
            // urFacesTableAdapter
            // 
            this.urFacesTableAdapter.ClearBeforeFill = true;
            // 
            // depositsTableAdapter
            // 
            this.depositsTableAdapter.ClearBeforeFill = true;
            // 
            // creditsTableAdapter
            // 
            this.creditsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Вклады";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Кредиты";
            // 
            // DCUrFaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelCredButton);
            this.Controls.Add(this.DelDepButton);
            this.Controls.Add(this.AddCredButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddDepButton);
            this.Controls.Add(this.ClientsGridView);
            this.Controls.Add(this.CredGridView);
            this.Controls.Add(this.DepGridView);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ShortNameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "DCUrFaces";
            this.Text = "DCUrFaces";
            this.Activated += new System.EventHandler(this.DCFizFaces_Activated);
            this.Load += new System.EventHandler(this.DCUrFaces_Load);
            this.Click += new System.EventHandler(this.DCFizFaces_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urFacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CredGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DelCredButton;
        private System.Windows.Forms.Button DelDepButton;
        private System.Windows.Forms.Button AddCredButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddDepButton;
        private System.Windows.Forms.DataGridView ClientsGridView;
        private System.Windows.Forms.DataGridView CredGridView;
        private System.Windows.Forms.DataGridView DepGridView;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox ShortNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private SmallBankDataSet smallBankDataSet;
        private System.Windows.Forms.BindingSource urFacesBindingSource;
        private SmallBankDataSetTableAdapters.UrFacesTableAdapter urFacesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource depositsBindingSource;
        private SmallBankDataSetTableAdapters.DepositsTableAdapter depositsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn summDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource creditsBindingSource;
        private SmallBankDataSetTableAdapters.CreditsTableAdapter creditsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn summDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn restDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExpDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTarifDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}