namespace SmallBankApp
{
    partial class CreditsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.RestTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SumTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TarifComboBox = new System.Windows.Forms.ComboBox();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.IdComboBox = new System.Windows.Forms.ComboBox();
            this.smallBankDataSet = new SmallBankApp.SmallBankDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.SurTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.creditsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditsTableAdapter = new SmallBankApp.SmallBankDataSetTableAdapters.CreditsTableAdapter();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.dicTarifCredBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dicTarifCredTableAdapter = new SmallBankApp.SmallBankDataSetTableAdapters.DicTarifCredTableAdapter();
            this.fizFacesTableAdapter1 = new SmallBankApp.SmallBankDataSetTableAdapters.FizFacesTableAdapter();
            this.urFacesTableAdapter1 = new SmallBankApp.SmallBankDataSetTableAdapters.UrFacesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicTarifCredBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(519, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Остаток";
            // 
            // RestTextBox
            // 
            this.RestTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestTextBox.Location = new System.Drawing.Point(713, 97);
            this.RestTextBox.Mask = "000000000000000000.00";
            this.RestTextBox.Name = "RestTextBox";
            this.RestTextBox.Size = new System.Drawing.Size(203, 26);
            this.RestTextBox.TabIndex = 37;
            // 
            // SumTextBox
            // 
            this.SumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumTextBox.Location = new System.Drawing.Point(713, 66);
            this.SumTextBox.Mask = "000000000000000000.00";
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(203, 26);
            this.SumTextBox.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(519, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Сумма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(519, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Дата открытия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(519, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Дата завершения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(519, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Тариф";
            // 
            // TarifComboBox
            // 
            this.TarifComboBox.DataSource = this.dicTarifCredBindingSource;
            this.TarifComboBox.DisplayMember = "Name";
            this.TarifComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TarifComboBox.FormattingEnabled = true;
            this.TarifComboBox.Location = new System.Drawing.Point(713, 193);
            this.TarifComboBox.Name = "TarifComboBox";
            this.TarifComboBox.Size = new System.Drawing.Size(203, 28);
            this.TarifComboBox.TabIndex = 31;
            this.TarifComboBox.ValueMember = "Name";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDateTimePicker.Location = new System.Drawing.Point(713, 161);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(203, 26);
            this.EndDateTimePicker.TabIndex = 30;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDateTimePicker.Location = new System.Drawing.Point(713, 129);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(203, 26);
            this.StartDateTimePicker.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(519, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "ID";
            // 
            // IdComboBox
            // 
            this.IdComboBox.DataSource = this.creditsBindingSource;
            this.IdComboBox.DisplayMember = "IdCred";
            this.IdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdComboBox.FormattingEnabled = true;
            this.IdComboBox.Location = new System.Drawing.Point(713, 32);
            this.IdComboBox.Name = "IdComboBox";
            this.IdComboBox.Size = new System.Drawing.Size(203, 28);
            this.IdComboBox.TabIndex = 39;
            this.IdComboBox.ValueMember = "IdCred";
            this.IdComboBox.SelectedIndexChanged += new System.EventHandler(this.IdComboBox_SelectedIndexChanged);
            // 
            // smallBankDataSet
            // 
            this.smallBankDataSet.DataSetName = "SmallBankDataSet";
            this.smallBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(30, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Наименование";
            // 
            // SurTextBox
            // 
            this.SurTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurTextBox.Location = new System.Drawing.Point(195, 57);
            this.SurTextBox.Name = "SurTextBox";
            this.SurTextBox.ReadOnly = true;
            this.SurTextBox.Size = new System.Drawing.Size(289, 26);
            this.SurTextBox.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(30, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 24);
            this.label10.TabIndex = 47;
            this.label10.Text = "Владелец";
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
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(628, 241);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(126, 39);
            this.SaveButton.TabIndex = 49;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(790, 241);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(126, 39);
            this.CancelButton.TabIndex = 48;
            this.CancelButton.Text = "Закрыть";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // dicTarifCredBindingSource
            // 
            this.dicTarifCredBindingSource.DataMember = "DicTarifCred";
            this.dicTarifCredBindingSource.DataSource = this.smallBankDataSet;
            // 
            // dicTarifCredTableAdapter
            // 
            this.dicTarifCredTableAdapter.ClearBeforeFill = true;
            // 
            // fizFacesTableAdapter1
            // 
            this.fizFacesTableAdapter1.ClearBeforeFill = true;
            // 
            // urFacesTableAdapter1
            // 
            this.urFacesTableAdapter1.ClearBeforeFill = true;
            // 
            // CreditsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 288);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SurTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RestTextBox);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TarifComboBox);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.StartDateTimePicker);
            this.Name = "CreditsForm";
            this.Text = "CreditsForm";
            this.Load += new System.EventHandler(this.CreditsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicTarifCredBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox RestTextBox;
        private System.Windows.Forms.MaskedTextBox SumTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TarifComboBox;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox IdComboBox;
        private SmallBankDataSet smallBankDataSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SurTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource creditsBindingSource;
        private SmallBankDataSetTableAdapters.CreditsTableAdapter creditsTableAdapter;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.BindingSource dicTarifCredBindingSource;
        private SmallBankDataSetTableAdapters.DicTarifCredTableAdapter dicTarifCredTableAdapter;
        private SmallBankDataSetTableAdapters.FizFacesTableAdapter fizFacesTableAdapter1;
        private SmallBankDataSetTableAdapters.UrFacesTableAdapter urFacesTableAdapter1;
    }
}