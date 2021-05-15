using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallBankApp
{
    public partial class FormsForm : Form
    {
        public FormsForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm menu = new MainForm();
            menu.IsLogin = true;
            menu.Show();
            this.Close();
        }

        private void DepFizButton_Click(object sender, EventArgs e)
        {
            DCFizFaces form = new DCFizFaces();
            form.Show();
            this.Close();
        }

        private void DepUrButton_Click(object sender, EventArgs e)
        {
            DCUrFaces form = new DCUrFaces();
            form.Show();
            this.Close();
        }

        private void FizButton_Click(object sender, EventArgs e)
        {
            FizFaces form = new FizFaces();
            form.Show();
            this.Close();
        }

        private void CredButton_Click(object sender, EventArgs e)
        {
            CreditsForm form = new CreditsForm();
            form.Show();
            this.Close();
        }

        private void DepButton_Click(object sender, EventArgs e)
        {
            DepForm form = new DepForm();
            form.Show();
            this.Close();
        }
    }
}
