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
        public DCFizFaces ptr { get; set; }



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
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectInputs())
            {
                MessageBox.Show("Некоректные данные");
            }
            else
            {
                
                DCFizFaces.CreditModel.IdClient = Id;
                DCFizFaces.CreditModel.IdTarif = dicTarifCredTableAdapter.GetData().First(t => t.Name == TarifComboBox.Text).IdTarif;
                DCFizFaces.CreditModel.Sum = Convert.ToDecimal(SumTextBox.Text);
                DCFizFaces.CreditModel.Rest = Convert.ToDecimal(RestTextBox.Text);
                DCFizFaces.CreditModel.DateStart = StartDateTimePicker.Value;
                DCFizFaces.CreditModel.DateEnd = EndDateTimePicker.Value;
                ptr.IsReady = true;
                ptr.IsDep = false;
                this.Close();


            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

