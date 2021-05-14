namespace SmallBankApp
{
    partial class FormsForm
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
            this.DepFizButton = new System.Windows.Forms.Button();
            this.DulFizButton = new System.Windows.Forms.Button();
            this.CredButton = new System.Windows.Forms.Button();
            this.FizButton = new System.Windows.Forms.Button();
            this.DulUrButton = new System.Windows.Forms.Button();
            this.DepUrButton = new System.Windows.Forms.Button();
            this.DepButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DepFizButton
            // 
            this.DepFizButton.Location = new System.Drawing.Point(87, 56);
            this.DepFizButton.Margin = new System.Windows.Forms.Padding(2);
            this.DepFizButton.Name = "DepFizButton";
            this.DepFizButton.Size = new System.Drawing.Size(176, 35);
            this.DepFizButton.TabIndex = 0;
            this.DepFizButton.Text = "Вклады и кредиты \r\nФизических лиц";
            this.DepFizButton.UseVisualStyleBackColor = true;
            this.DepFizButton.Click += new System.EventHandler(this.DepFizButton_Click);
            // 
            // DulFizButton
            // 
            this.DulFizButton.Location = new System.Drawing.Point(87, 112);
            this.DulFizButton.Margin = new System.Windows.Forms.Padding(2);
            this.DulFizButton.Name = "DulFizButton";
            this.DulFizButton.Size = new System.Drawing.Size(176, 35);
            this.DulFizButton.TabIndex = 1;
            this.DulFizButton.Text = "ДУЛ Физических лиц";
            this.DulFizButton.UseVisualStyleBackColor = true;
            // 
            // CredButton
            // 
            this.CredButton.Location = new System.Drawing.Point(304, 171);
            this.CredButton.Margin = new System.Windows.Forms.Padding(2);
            this.CredButton.Name = "CredButton";
            this.CredButton.Size = new System.Drawing.Size(176, 32);
            this.CredButton.TabIndex = 2;
            this.CredButton.Text = "Кредиты";
            this.CredButton.UseVisualStyleBackColor = true;
            // 
            // FizButton
            // 
            this.FizButton.Location = new System.Drawing.Point(234, 234);
            this.FizButton.Margin = new System.Windows.Forms.Padding(2);
            this.FizButton.Name = "FizButton";
            this.FizButton.Size = new System.Drawing.Size(111, 47);
            this.FizButton.TabIndex = 3;
            this.FizButton.Text = "Физические лица";
            this.FizButton.UseVisualStyleBackColor = true;
            this.FizButton.Click += new System.EventHandler(this.FizButton_Click);
            // 
            // DulUrButton
            // 
            this.DulUrButton.Location = new System.Drawing.Point(304, 112);
            this.DulUrButton.Margin = new System.Windows.Forms.Padding(2);
            this.DulUrButton.Name = "DulUrButton";
            this.DulUrButton.Size = new System.Drawing.Size(176, 41);
            this.DulUrButton.TabIndex = 4;
            this.DulUrButton.Text = "ДУЛ Юридических лиц";
            this.DulUrButton.UseVisualStyleBackColor = true;
            // 
            // DepUrButton
            // 
            this.DepUrButton.Location = new System.Drawing.Point(304, 56);
            this.DepUrButton.Margin = new System.Windows.Forms.Padding(2);
            this.DepUrButton.Name = "DepUrButton";
            this.DepUrButton.Size = new System.Drawing.Size(176, 35);
            this.DepUrButton.TabIndex = 5;
            this.DepUrButton.Text = "Вклады и кредиты \r\nЮридических лиц";
            this.DepUrButton.UseVisualStyleBackColor = true;
            this.DepUrButton.Click += new System.EventHandler(this.DepUrButton_Click);
            // 
            // DepButton
            // 
            this.DepButton.Location = new System.Drawing.Point(87, 171);
            this.DepButton.Margin = new System.Windows.Forms.Padding(2);
            this.DepButton.Name = "DepButton";
            this.DepButton.Size = new System.Drawing.Size(176, 32);
            this.DepButton.TabIndex = 6;
            this.DepButton.Text = "Вклады";
            this.DepButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(234, 303);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(111, 32);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FormsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DepButton);
            this.Controls.Add(this.DepUrButton);
            this.Controls.Add(this.DulUrButton);
            this.Controls.Add(this.FizButton);
            this.Controls.Add(this.CredButton);
            this.Controls.Add(this.DulFizButton);
            this.Controls.Add(this.DepFizButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormsForm";
            this.Text = "FormsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DepFizButton;
        private System.Windows.Forms.Button DulFizButton;
        private System.Windows.Forms.Button CredButton;
        private System.Windows.Forms.Button FizButton;
        private System.Windows.Forms.Button DulUrButton;
        private System.Windows.Forms.Button DepUrButton;
        private System.Windows.Forms.Button DepButton;
        private System.Windows.Forms.Button BackButton;
    }
}