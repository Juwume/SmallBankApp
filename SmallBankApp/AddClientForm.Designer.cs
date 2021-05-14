namespace SmallBankApp
{
    partial class AddClientForm
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
            this.ResidentCheckBox = new System.Windows.Forms.CheckBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.smallBankDataSet = new SmallBankApp.SmallBankDataSet();
            this.dicTypeClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dicTypeClientTableAdapter = new SmallBankApp.SmallBankDataSetTableAdapters.DicTypeClientTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PatTextBox = new System.Windows.Forms.TextBox();
            this.SurTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.INNTextBox = new System.Windows.Forms.MaskedTextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.clientsTableAdapter1 = new SmallBankApp.SmallBankDataSetTableAdapters.ClientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicTypeClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ResidentCheckBox
            // 
            this.ResidentCheckBox.AutoSize = true;
            this.ResidentCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResidentCheckBox.Location = new System.Drawing.Point(228, 191);
            this.ResidentCheckBox.Name = "ResidentCheckBox";
            this.ResidentCheckBox.Size = new System.Drawing.Size(117, 28);
            this.ResidentCheckBox.TabIndex = 0;
            this.ResidentCheckBox.Text = "Резидент";
            this.ResidentCheckBox.UseVisualStyleBackColor = true;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DataSource = this.dicTypeClientBindingSource;
            this.TypeComboBox.DisplayMember = "Name";
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(186, 164);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(159, 21);
            this.TypeComboBox.TabIndex = 1;
            this.TypeComboBox.ValueMember = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(412, 259);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(186, 112);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(159, 20);
            this.AdressTextBox.TabIndex = 6;
            // 
            // smallBankDataSet
            // 
            this.smallBankDataSet.DataSetName = "SmallBankDataSet";
            this.smallBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dicTypeClientBindingSource
            // 
            this.dicTypeClientBindingSource.DataMember = "DicTypeClient";
            this.dicTypeClientBindingSource.DataSource = this.smallBankDataSet;
            // 
            // dicTypeClientTableAdapter
            // 
            this.dicTypeClientTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Отчество";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(47, 55);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(91, 24);
            this.SurnameLabel.TabIndex = 11;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(47, 31);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(46, 24);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Имя";
            // 
            // PatTextBox
            // 
            this.PatTextBox.Location = new System.Drawing.Point(186, 86);
            this.PatTextBox.Name = "PatTextBox";
            this.PatTextBox.Size = new System.Drawing.Size(159, 20);
            this.PatTextBox.TabIndex = 9;
            // 
            // SurTextBox
            // 
            this.SurTextBox.Location = new System.Drawing.Point(186, 60);
            this.SurTextBox.Name = "SurTextBox";
            this.SurTextBox.Size = new System.Drawing.Size(159, 20);
            this.SurTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(186, 36);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(159, 20);
            this.NameTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "ИНН";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(47, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Тип";
            // 
            // INNTextBox
            // 
            this.INNTextBox.Location = new System.Drawing.Point(186, 138);
            this.INNTextBox.Name = "INNTextBox";
            this.INNTextBox.Size = new System.Drawing.Size(159, 20);
            this.INNTextBox.TabIndex = 16;
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.Location = new System.Drawing.Point(56, 230);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(95, 39);
            this.OkButton.TabIndex = 18;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(207, 230);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(104, 39);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Закрыть";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 323);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.INNTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PatTextBox);
            this.Controls.Add(this.SurTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.ResidentCheckBox);
            this.Name = "AddClientForm";
            this.Text = "AddClientForm";
            this.Activated += new System.EventHandler(this.AddClientForm_Activated);
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicTypeClientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ResidentCheckBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox AdressTextBox;
        private SmallBankDataSet smallBankDataSet;
        private System.Windows.Forms.BindingSource dicTypeClientBindingSource;
        private SmallBankDataSetTableAdapters.DicTypeClientTableAdapter dicTypeClientTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox PatTextBox;
        private System.Windows.Forms.TextBox SurTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox INNTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private SmallBankDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter1;
    }
}