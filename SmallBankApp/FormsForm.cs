﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maket
{
    public partial class FormsForm : Form
    {
        public FormsForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            GeneralMenu menu = new GeneralMenu();
            menu.Show();
            this.Close();
        }

        private void DepFizButton_Click(object sender, EventArgs e)
        {
            DepFizForm depFizForm = new DepFizForm();
            depFizForm.Show();
            this.Close();
        }
    }
}