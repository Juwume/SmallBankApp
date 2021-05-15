namespace SmallBankApp
{
    partial class DepForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SurTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IdComboBox = new System.Windows.Forms.ComboBox();
            this.depositsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smallBankDataSet = new SmallBankApp.SmallBankDataSet();
            this.SumTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TarifComboBox = new System.Windows.Forms.ComboBox();
            this.dicTarifDepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.depositsTableAdapter = new SmallBankApp.SmallBankDataSetTableAdapters.DepositsTableAdapter();
            this.dicTarifDepTableAdapter = new SmallBankApp.SmallBankDataSetTableAdapters.DicTarifDepTableAdapter();
            this.fizFacesTableAdapter1 = new SmallBankApp.SmallBankDataSetTableAdapters.FizFacesTableAdapter();
            this.urFacesTableAdapter1 = new SmallBankApp.SmallBankDataSetTableAdapters.UrFacesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.depositsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicTarifDepBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(610, 198);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(126, 39);
            this.SaveButton.TabIndex = 66;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(772, 198);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(126, 39);
            this.CancelButton.TabIndex = 65;
            this.CancelButton.Text = "Закрыть";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 24);
            this.label10.TabIndex = 64;
            this.label10.Text = "Владелец";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 24);
            this.label7.TabIndex = 63;
            this.label7.Text = "Наименование";
            // 
            // SurTextBox
            // 
            this.SurTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurTextBox.Location = new System.Drawing.Point(177, 45);
            this.SurTextBox.Name = "SurTextBox";
            this.SurTextBox.ReadOnly = true;
            this.SurTextBox.Size = new System.Drawing.Size(289, 26);
            this.SurTextBox.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(501, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 24);
            this.label6.TabIndex = 61;
            this.label6.Text = "ID";
            // 
            // IdComboBox
            // 
            this.IdComboBox.DataSource = this.depositsBindingSource;
            this.IdComboBox.DisplayMember = "IdDep";
            this.IdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdComboBox.FormattingEnabled = true;
            this.IdComboBox.Location = new System.Drawing.Point(695, 20);
            this.IdComboBox.Name = "IdComboBox";
            this.IdComboBox.Size = new System.Drawing.Size(203, 28);
            this.IdComboBox.TabIndex = 60;
            this.IdComboBox.ValueMember = "IdDep";
            this.IdComboBox.SelectedIndexChanged += new System.EventHandler(this.IdComboBox_SelectedIndexChanged);
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
            // SumTextBox
            // 
            this.SumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumTextBox.Location = new System.Drawing.Point(695, 54);
            this.SumTextBox.Mask = "000000000000000000.00";
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(203, 26);
            this.SumTextBox.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(501, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 55;
            this.label5.Text = "Сумма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(501, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "Дата открытия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(501, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Дата завершения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(501, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "Тариф";
            // 
            // TarifComboBox
            // 
            this.TarifComboBox.DataSource = this.dicTarifDepBindingSource;
            this.TarifComboBox.DisplayMember = "Name";
            this.TarifComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TarifComboBox.FormattingEnabled = true;
            this.TarifComboBox.Location = new System.Drawing.Point(695, 150);
            this.TarifComboBox.Name = "TarifComboBox";
            this.TarifComboBox.Size = new System.Drawing.Size(203, 28);
            this.TarifComboBox.TabIndex = 52;
            this.TarifComboBox.ValueMember = "Name";
            // 
            // dicTarifDepBindingSource
            // 
            this.dicTarifDepBindingSource.DataMember = "DicTarifDep";
            this.dicTarifDepBindingSource.DataSource = this.smallBankDataSet;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDateTimePicker.Location = new System.Drawing.Point(695, 118);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(203, 26);
            this.EndDateTimePicker.TabIndex = 51;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDateTimePicker.Location = new System.Drawing.Point(695, 86);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(203, 26);
            this.StartDateTimePicker.TabIndex = 50;
            // 
            // depositsTableAdapter
            // 
            this.depositsTableAdapter.ClearBeforeFill = true;
            // 
            // dicTarifDepTableAdapter
            // 
            this.dicTarifDepTableAdapter.ClearBeforeFill = true;
            // 
            // fizFacesTableAdapter1
            // 
            this.fizFacesTableAdapter1.ClearBeforeFill = true;
            // 
            // urFacesTableAdapter1
            // 
            this.urFacesTableAdapter1.ClearBeforeFill = true;
            // 
            // DepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 261);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SurTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdComboBox);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TarifComboBox);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.StartDateTimePicker);
            this.Name = "DepForm";
            this.Text = "DepForm";
            this.Load += new System.EventHandler(this.DepForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depositsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicTarifDepBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SurTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox IdComboBox;
        private System.Windows.Forms.MaskedTextBox SumTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TarifComboBox;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private SmallBankDataSet smallBankDataSet;
        private System.Windows.Forms.BindingSource depositsBindingSource;
        private SmallBankDataSetTableAdapters.DepositsTableAdapter depositsTableAdapter;
        private System.Windows.Forms.BindingSource dicTarifDepBindingSource;
        private SmallBankDataSetTableAdapters.DicTarifDepTableAdapter dicTarifDepTableAdapter;
        private SmallBankDataSetTableAdapters.FizFacesTableAdapter fizFacesTableAdapter1;
        private SmallBankDataSetTableAdapters.UrFacesTableAdapter urFacesTableAdapter1;
    }
}