namespace SmallBankApp
{
    partial class AddCreditForm
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
            this.SumTextBox = new System.Windows.Forms.MaskedTextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TarifComboBox = new System.Windows.Forms.ComboBox();
            this.dicTarifCredBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smallBankDataSet = new SmallBankApp.SmallBankDataSet();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RestTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dicTarifCredTableAdapter = new SmallBankApp.SmallBankDataSetTableAdapters.DicTarifCredTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.SurTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dicTarifCredBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SumTextBox
            // 
            this.SumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumTextBox.Location = new System.Drawing.Point(241, 61);
            this.SumTextBox.Mask = "000000000000000000.00";
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(203, 26);
            this.SumTextBox.TabIndex = 26;
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.Location = new System.Drawing.Point(114, 259);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(95, 39);
            this.OkButton.TabIndex = 25;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(265, 259);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(104, 39);
            this.CancelButton.TabIndex = 24;
            this.CancelButton.Text = "Закрыть";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(47, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Сумма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(47, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Дата открытия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Дата завершения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Тариф";
            // 
            // TarifComboBox
            // 
            this.TarifComboBox.DataSource = this.dicTarifCredBindingSource;
            this.TarifComboBox.DisplayMember = "Name";
            this.TarifComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TarifComboBox.FormattingEnabled = true;
            this.TarifComboBox.Location = new System.Drawing.Point(241, 188);
            this.TarifComboBox.Name = "TarifComboBox";
            this.TarifComboBox.Size = new System.Drawing.Size(203, 28);
            this.TarifComboBox.TabIndex = 17;
            this.TarifComboBox.ValueMember = "Name";
            // 
            // dicTarifCredBindingSource
            // 
            this.dicTarifCredBindingSource.DataMember = "DicTarifCred";
            this.dicTarifCredBindingSource.DataSource = this.smallBankDataSet;
            // 
            // smallBankDataSet
            // 
            this.smallBankDataSet.DataSetName = "SmallBankDataSet";
            this.smallBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDateTimePicker.Location = new System.Drawing.Point(241, 156);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(203, 26);
            this.EndDateTimePicker.TabIndex = 16;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDateTimePicker.Location = new System.Drawing.Point(241, 124);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(203, 26);
            this.StartDateTimePicker.TabIndex = 15;
            // 
            // RestTextBox
            // 
            this.RestTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestTextBox.Location = new System.Drawing.Point(241, 92);
            this.RestTextBox.Mask = "000000000000000000.00";
            this.RestTextBox.Name = "RestTextBox";
            this.RestTextBox.Size = new System.Drawing.Size(203, 26);
            this.RestTextBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Остаток";
            // 
            // dicTarifCredTableAdapter
            // 
            this.dicTarifCredTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(47, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Наименование";
            // 
            // SurTextBox
            // 
            this.SurTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurTextBox.Location = new System.Drawing.Point(241, 25);
            this.SurTextBox.Name = "SurTextBox";
            this.SurTextBox.ReadOnly = true;
            this.SurTextBox.Size = new System.Drawing.Size(203, 26);
            this.SurTextBox.TabIndex = 29;
            // 
            // AddCreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 342);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SurTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RestTextBox);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TarifComboBox);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.StartDateTimePicker);
            this.Name = "AddCreditForm";
            this.Text = "AddCreditForm";
            this.Load += new System.EventHandler(this.AddCreditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dicTarifCredBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox SumTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TarifComboBox;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.MaskedTextBox RestTextBox;
        private System.Windows.Forms.Label label3;
        private SmallBankDataSet smallBankDataSet;
        private System.Windows.Forms.BindingSource dicTarifCredBindingSource;
        private SmallBankDataSetTableAdapters.DicTarifCredTableAdapter dicTarifCredTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SurTextBox;
    }
}