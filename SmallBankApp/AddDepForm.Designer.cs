namespace SmallBankApp
{
    partial class AddDepForm
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
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TarifComboBox = new System.Windows.Forms.ComboBox();
            this.dicTarifDepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smallBankDataSet = new SmallBankApp.SmallBankDataSet();
            this.SurTextBox = new System.Windows.Forms.TextBox();
            this.dicTarifDepTableAdapter = new SmallBankApp.SmallBankDataSetTableAdapters.DicTarifDepTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.SumTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dicTarifDepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDateTimePicker.Location = new System.Drawing.Point(211, 120);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(203, 26);
            this.StartDateTimePicker.TabIndex = 4;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDateTimePicker.Location = new System.Drawing.Point(211, 152);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(203, 26);
            this.EndDateTimePicker.TabIndex = 5;
            // 
            // TarifComboBox
            // 
            this.TarifComboBox.DataSource = this.dicTarifDepBindingSource;
            this.TarifComboBox.DisplayMember = "Name";
            this.TarifComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TarifComboBox.FormattingEnabled = true;
            this.TarifComboBox.Location = new System.Drawing.Point(211, 184);
            this.TarifComboBox.Name = "TarifComboBox";
            this.TarifComboBox.Size = new System.Drawing.Size(203, 28);
            this.TarifComboBox.TabIndex = 6;
            this.TarifComboBox.ValueMember = "Name";
            // 
            // dicTarifDepBindingSource
            // 
            this.dicTarifDepBindingSource.DataMember = "DicTarifDep";
            this.dicTarifDepBindingSource.DataSource = this.smallBankDataSet;
            // 
            // smallBankDataSet
            // 
            this.smallBankDataSet.DataSetName = "SmallBankDataSet";
            this.smallBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SurTextBox
            // 
            this.SurTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurTextBox.Location = new System.Drawing.Point(211, 56);
            this.SurTextBox.Name = "SurTextBox";
            this.SurTextBox.ReadOnly = true;
            this.SurTextBox.Size = new System.Drawing.Size(203, 26);
            this.SurTextBox.TabIndex = 7;
            // 
            // dicTarifDepTableAdapter
            // 
            this.dicTarifDepTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Тариф";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дата завершения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата открытия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Сумма";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Наименование";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(235, 255);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(104, 39);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Закрыть";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.Location = new System.Drawing.Point(84, 255);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(95, 39);
            this.OkButton.TabIndex = 13;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SumTextBox
            // 
            this.SumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumTextBox.Location = new System.Drawing.Point(211, 88);
            this.SumTextBox.Mask = "000000000000000000.00";
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(203, 26);
            this.SumTextBox.TabIndex = 14;
            // 
            // AddDepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SurTextBox);
            this.Controls.Add(this.TarifComboBox);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.StartDateTimePicker);
            this.Name = "AddDepForm";
            this.Text = "AddDepForm";
            this.Load += new System.EventHandler(this.AddDepForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dicTarifDepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallBankDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.ComboBox TarifComboBox;
        private System.Windows.Forms.TextBox SurTextBox;
        private SmallBankDataSet smallBankDataSet;
        private System.Windows.Forms.BindingSource dicTarifDepBindingSource;
        private SmallBankDataSetTableAdapters.DicTarifDepTableAdapter dicTarifDepTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.MaskedTextBox SumTextBox;
    }
}