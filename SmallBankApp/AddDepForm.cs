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
    public partial class AddDepForm : Form
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public DCFizFaces ptr {get;set;}



        public AddDepForm()
        {
            InitializeComponent();
        }
        public bool isIncorrectInputs()
        {
            return SumTextBox.Text == "                  ," || StartDateTimePicker.Value >= EndDateTimePicker.Value || TarifComboBox.SelectedIndex < 0;
        }

        private void AddDepForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smallBankDataSet.DicTarifDep". При необходимости она может быть перемещена или удалена.
            this.dicTarifDepTableAdapter.Fill(this.smallBankDataSet.DicTarifDep);
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

                DCFizFaces.DepModel.IdClient = Id;
                DCFizFaces.DepModel.IdTarif = dicTarifDepTableAdapter.GetData().First(t => t.Name == TarifComboBox.Text).IdTarif;
                DCFizFaces.DepModel.Sum = Convert.ToDecimal(SumTextBox.Text);
                DCFizFaces.DepModel.DateStart = StartDateTimePicker.Value;
                DCFizFaces.DepModel.DateEnd = EndDateTimePicker.Value;
                ptr.IsReady = true;
                ptr.IsDep = true;
                this.Close();


            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
