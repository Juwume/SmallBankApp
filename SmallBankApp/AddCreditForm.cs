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
    public partial class AddCreditForm : Form
    {
        
        public int Id { get; set; }
        public string Surname { get; set; }
        public DCFizFaces PtrFiz { get; set; }
        public DCUrFaces PtrUr { get; set; }



        public AddCreditForm()
        {
            InitializeComponent();
        }
        public bool isIncorrectInputs()
        {
            return SumTextBox.Text == "                  ," || RestTextBox.Text == "                  ," || StartDateTimePicker.Value >= EndDateTimePicker.Value || TarifComboBox.SelectedIndex < 0;
        }

        private void AddCreditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smallBankDataSet.DicTarifCred". При необходимости она может быть перемещена или удалена.
            this.dicTarifCredTableAdapter.Fill(this.smallBankDataSet.DicTarifCred);
            SurTextBox.Text = Surname;
            TarifComboBox.SelectedIndex = -1;

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectInputs() || (PtrFiz == null && PtrUr == null))
            {
                MessageBox.Show("Некоректные данные");
            }
            else if (PtrFiz != null)
            {
                
                DCFizFaces.CreditModel.IdClient = Id;
                DCFizFaces.CreditModel.IdTarif = dicTarifCredTableAdapter.GetData().First(t => t.Name == TarifComboBox.Text).IdTarif;
                DCFizFaces.CreditModel.Sum = Convert.ToDecimal(SumTextBox.Text);
                DCFizFaces.CreditModel.Rest = Convert.ToDecimal(RestTextBox.Text);
                DCFizFaces.CreditModel.DateStart = StartDateTimePicker.Value;
                DCFizFaces.CreditModel.DateEnd = EndDateTimePicker.Value;
                PtrFiz.IsReady = true;
                PtrFiz.IsDep = false;
                this.Close();


            }
            else
            {
                DCUrFaces.CreditModel.IdClient = Id;
                DCUrFaces.CreditModel.IdTarif = dicTarifCredTableAdapter.GetData().First(t => t.Name == TarifComboBox.Text).IdTarif;
                DCUrFaces.CreditModel.Sum = Convert.ToDecimal(SumTextBox.Text);
                DCUrFaces.CreditModel.Rest = Convert.ToDecimal(RestTextBox.Text);
                DCUrFaces.CreditModel.DateStart = StartDateTimePicker.Value;
                DCUrFaces.CreditModel.DateEnd = EndDateTimePicker.Value;
                PtrUr.IsReady = true;
                PtrUr.IsDep = false;
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

